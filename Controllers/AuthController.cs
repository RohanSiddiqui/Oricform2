using Microsoft.Extensions.Logging;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using Oricform2.Data;
using Oricform2.Models;
using System.Security.Claims;
using Microsoft.IdentityModel.Tokens;
using System.IdentityModel.Tokens.Jwt;
using System.Text;
using Oricform2.DTOs;
using Newtonsoft.Json;
using Microsoft.AspNetCore.Identity;
using System.Security.Cryptography;
using System.Threading.Tasks;

namespace Oricform2.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class AuthController : ControllerBase
    {
        private readonly ILogger<AuthController> _logger;
        private readonly ApplicationDbContext _context;
        private readonly IConfiguration _configuration;
        private readonly EmailService _emailService;

        public AuthController(ApplicationDbContext context, IConfiguration configuration, EmailService emailService, ILogger<AuthController> logger)
        {
            _context = context;
            _configuration = configuration;
            _emailService = emailService;
            _logger = logger;
        }

        [HttpPost("login")]
        public async Task<IActionResult> Login(UserLoginDTO loginDto)
        {
            Console.WriteLine("Login attempt with email: " + loginDto.email);

            var user = await _context.dataoric.SingleOrDefaultAsync(u => u.email == loginDto.email);

            if (user == null || user.password != loginDto.password)
            {
                Console.WriteLine("Invalid credentials for email: " + loginDto.email);
                return Unauthorized("Invalid credentials");
            }

            Console.WriteLine("Login successful for user: " + user.name);
            var token = GenerateJwtToken(user);

            return Ok(new
            {
                Token = token,
                Email = user.email,
                Role = user.role,
                Name = user.name
            });
        }

        private string GenerateJwtToken(Login user)
        {
            var tokenHandler = new JwtSecurityTokenHandler();
            var key = Encoding.UTF8.GetBytes(_configuration["Jwt:Key"] ?? throw new InvalidOperationException("JWT key not set"));

            var claims = new[]
            {
                new Claim(ClaimTypes.Name, user.name),
                new Claim(ClaimTypes.Email, user.email),
                new Claim(ClaimTypes.Role, user.role),
                new Claim("UserId", user.dataoric_id.ToString()),
                new Claim(JwtRegisteredClaimNames.Sub, user.email),
                new Claim(JwtRegisteredClaimNames.Jti, Guid.NewGuid().ToString()),
            };

            var tokenDescriptor = new SecurityTokenDescriptor
            {
                Subject = new ClaimsIdentity(claims),
                Expires = DateTime.UtcNow.AddHours(1),
                Issuer = _configuration["Jwt:Issuer"],
                Audience = _configuration["Jwt:Audience"],
                SigningCredentials = new SigningCredentials(new SymmetricSecurityKey(key), SecurityAlgorithms.HmacSha256Signature)
            };

            var token = tokenHandler.CreateToken(tokenDescriptor);
            return tokenHandler.WriteToken(token);
        }

        [HttpPost("add-user")]
        public async Task<IActionResult> AddUser([FromBody] UserAddDto userDto)
        {
            var existingUser = await _context.dataoric.FirstOrDefaultAsync(u => u.email == userDto.email);
            if (existingUser != null)
            {
                return BadRequest("User already exists.");
            }

            string generatedPassword = GenerateRandomPassword();
            string hashedPassword = HashPassword(generatedPassword);

            var newUser = new Login
            {
                email = userDto.email,
                password = hashedPassword,
                role = userDto.role
            };

            _context.dataoric.Add(newUser);
            await _context.SaveChangesAsync();

            await _emailService.SendEmailAsync(userDto.email, "Your New Account", $"Your password: {generatedPassword}");

            return Ok("User added successfully, password sent to email.");
        }

        [HttpPost("forgot-password")]
        public async Task<IActionResult> ForgotPassword([FromBody] ForgotPasswordDto forgotPasswordDto)
        {
            var user = await _context.dataoric.FirstOrDefaultAsync(u => u.email == forgotPasswordDto.Email);
            if (user == null)
            {
                return NotFound("User not found.");
            }

            string newPassword = GenerateRandomPassword();
            string hashedNewPassword = HashPassword(newPassword);

            user.password = hashedNewPassword;
            await _context.SaveChangesAsync();

            await _emailService.SendEmailAsync(forgotPasswordDto.Email, "Password Reset", $"Your new password: {newPassword}");

            return Ok("New password sent to your email.");
        }

        [HttpPost("send-test-email")]
        public async Task<IActionResult> SendTestEmail()
        {
            await _emailService.SendEmailAsync("test@example.com", "Test Email", "This is a test email from the ORIC system.");
            return Ok("Test email sent!");
        }

        private string GenerateRandomPassword()
        {
            const string chars = "ABCDEFGHIJKLMNOPQRSTUVWXYZabcdefghijklmnopqrstuvwxyz0123456789";
            var random = new Random();
            return new string(Enumerable.Repeat(chars, 8)
              .Select(s => s[random.Next(s.Length)]).ToArray());
        }

        private string HashPassword(string password)
        {
            using var sha256 = SHA256.Create();
            byte[] bytes = sha256.ComputeHash(Encoding.UTF8.GetBytes(password));
            StringBuilder builder = new StringBuilder();
            foreach (var b in bytes)
            {
                builder.Append(b.ToString("x2"));
            }
            return builder.ToString();
        }
    }
}
