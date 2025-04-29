using System.ComponentModel.DataAnnotations;

namespace Project.Models
{
    public class FacultyRegistration
    {
        public Guid Id { get; set; }

        [Required]
        public string full_name { get; set; }

        public string dep { get; set; }

   
        [Required]
        [EmailAddress]
        public string email { get; set; }

        [Required]
        public string password { get; set; }
        public string role { get; set; }
    }
}
