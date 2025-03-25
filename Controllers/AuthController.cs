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


namespace WebApi.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class AuthController : ControllerBase
    {
        private readonly ILogger<AuthController> _logger;
        private readonly ApplicationDbContext _context;
        private readonly IConfiguration _configuration;

        public AuthController(ApplicationDbContext context, IConfiguration configuration, ILogger<AuthController> logger)
        {
            _context = context;
            _configuration = configuration;
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

            // Print token details to the con'sole
            Console.WriteLine("JWT Token: " + token);
            Console.WriteLine("User email: " + user.email);
            Console.WriteLine("User role: " + user.role);
            Console.WriteLine("User name: " + user.name);

            // Return the token and user details in the respons
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
        new Claim("UserId", user.dataoric_id.ToString()),  // Adding UserId claim for better control
        new Claim(JwtRegisteredClaimNames.Sub, user.email),  // Subject of the token
        new Claim(JwtRegisteredClaimNames.Jti, Guid.NewGuid().ToString()),  // JWT ID
    };

            var tokenDescriptor = new SecurityTokenDescriptor
            {
                Subject = new ClaimsIdentity(claims),
                Expires = DateTime.UtcNow.AddHours(1),
                Issuer = _configuration["Jwt:Issuer"],  // Set the Issuer
                Audience = _configuration["Jwt:Audience"],  // Set the Audience
                SigningCredentials = new SigningCredentials(new SymmetricSecurityKey(key), SecurityAlgorithms.HmacSha256Signature)
            };

            var token = tokenHandler.CreateToken(tokenDescriptor);
            var jwtToken = tokenHandler.WriteToken(token);
            return jwtToken;
        }
    }
}

