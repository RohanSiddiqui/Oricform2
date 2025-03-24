using System.ComponentModel.DataAnnotations;

namespace Oricform2.DTOs
{
    public class UserAddDto
    {
        [Required]
        public string name { get; set; }
        public string email { get; set; }
        public string role { get; set; }
     
    }
}
