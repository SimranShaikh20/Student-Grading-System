using System.ComponentModel.DataAnnotations;

namespace Project.Models
{
    public class Register
    {
        public Guid Id { get; set; }

        [Required]
        public string full_name { get; set; }

        public int sem { get; set; }
        public int year { get; set; }

        public string dep { get; set; }

        public long contact_no { get; set; }

        [Required]
        [EmailAddress]
        public string email { get; set; }

        [Required]
        public string PasswordHash { get; set; }
        public string role { get; set; } // 🔥 Added for authentication
    }
}
