using System.ComponentModel.DataAnnotations;

namespace Mastilearn.Web.Models
{
    public class ContactRequest
    {
        [Required, StringLength(100)]
        public string Name { get; set; } = string.Empty;

        [Required, EmailAddress, StringLength(200)]
        public string Email { get; set; } = string.Empty;

        [Required, StringLength(50)]
        public string Role { get; set; } = string.Empty; // Admin/Teacher/Parent

        [Required, StringLength(4000)]
        public string Message { get; set; } = string.Empty;
    }
}
