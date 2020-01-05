using System.ComponentModel.DataAnnotations;

namespace SmartWatchShopFP.Models
{
    public class Footer
    {
        public int Id { get; set; }

        [Required(ErrorMessage = "AddressFirstLine cannot be empty")]
        [MinLength(5, ErrorMessage = "AddressFirstLine must be at least {1} characters long")]
        [StringLength(100)]
        public string AddressFirstLine { get; set; }

        [Required(ErrorMessage = "AddressSecondLine cannot be empty")]
        [MinLength(5, ErrorMessage = "AddressSecondLine must be at least {1} characters long")]
        [StringLength(100)]
        public string AddressSecondLine { get; set; }

        [Required(ErrorMessage = "PhoneNumber cannot be empty")]
        [MinLength(5, ErrorMessage = "PhoneNumber must be at least {1} characters long")]
        [StringLength(100)]
        public string PhoneNumber { get; set; }

        [Required(ErrorMessage = "WorkingHours cannot be empty")]
        [MinLength(5, ErrorMessage = "WorkingHours must be at least {1} characters long")]
        [StringLength(100)]
        public string WorkingHours { get; set; }

        [Required(ErrorMessage = "Email cannot be empty")]
        [MinLength(5, ErrorMessage = "Email must be at least {1} characters long")]
        [StringLength(100)]
        public string Email { get; set; }
    }
}
