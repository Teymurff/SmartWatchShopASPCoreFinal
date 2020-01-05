using Microsoft.AspNetCore.Identity;
using System;
using System.ComponentModel.DataAnnotations;

namespace SmartWatchShopFP.Models
{
    public class WatchUser : IdentityUser
    {
        [Required(ErrorMessage = "Firstname cannot be empty")]
        [StringLength(256)]
        public string FirstName { get; set; }

        [Required(ErrorMessage = "Lastname cannot be empty")]
        [StringLength(256)]
        public string LastName { get; set; }

        [Required(ErrorMessage = "Birthdate cannot be empty")]
        [StringLength(256)]
        public DateTime Birthdate { get; set; }

        [Required(ErrorMessage = "Livingplace cannot be empty")]
        [StringLength(256)]
        public string Livingplace { get; set; }
    }
}
