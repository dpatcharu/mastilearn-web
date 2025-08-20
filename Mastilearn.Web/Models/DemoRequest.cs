using System.ComponentModel.DataAnnotations;

namespace Mastilearn.Web.Models
{
    public class DemoRequest
    {
        [Required, StringLength(100)]
        public string Name { get; set; } = string.Empty;

        [Required, EmailAddress, StringLength(200)]
        public string WorkEmail { get; set; } = string.Empty;

        [Required, StringLength(200)]
        public string Organization { get; set; } = string.Empty;

        [Required, StringLength(50)]
        public string Role { get; set; } = string.Empty;

        [Range(1, 100000)]
        public int? StudentsCount { get; set; }

        [StringLength(100)]
        public string Timezone { get; set; } = string.Empty;

        [StringLength(100)]
        public string PreferredTime { get; set; } = string.Empty;

        [StringLength(4000)]
        public string Notes { get; set; } = string.Empty;
    }
}
