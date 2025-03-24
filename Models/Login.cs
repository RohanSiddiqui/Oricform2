// Models/login.cs
using System.ComponentModel.DataAnnotations;

namespace Oricform2.Models
{
    public class Login
    {
        [Key]
        public int dataoric_id { get; set; }

        public string? email { get; set; }
        public required string name { get; set; }
        public  string? password { get; set; }
        public  string? role { get; set; }
        public int? department_id { get; set; } // Nullable for admin who may not belong to any department
    }
}
