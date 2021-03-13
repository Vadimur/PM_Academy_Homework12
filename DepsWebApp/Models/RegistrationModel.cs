using System.ComponentModel.DataAnnotations;

namespace DepsWebApp.Models
{
    /// <summary>
    /// Model for registration
    /// </summary>
    public class RegistrationModel
    {
        /// <summary>
        /// Registration login
        /// </summary>
        [Required]
        [StringLength(6)]
        public string Login { get; set; }

        /// <summary>
        /// Registration password
        /// </summary>
        [Required]
        [StringLength(6)]
        public string Password { get; set; }
    }
}