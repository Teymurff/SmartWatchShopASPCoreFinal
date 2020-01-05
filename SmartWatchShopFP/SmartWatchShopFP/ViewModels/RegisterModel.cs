using SmartWatchShopFP.Models;
using System;
using System.ComponentModel.DataAnnotations;

namespace SmartWatchShopFP.ViewModels
{
    public class RegisterModel
    {
        [Required]
        public string Firstname { get; set; }

        public string Lastname { get; set; }

        [Required]
        public string Livingplace { get; set; }

        [Required]
        public string Email { get; set; }

        [Required]
        public string Username { get; set; }

        [Required]
        [DataType(DataType.Password)]
        public string Password { get; set; }

        [Required]
        [DataType(DataType.Password)]
        [Compare(nameof(Password))]
        public string ConfirmPassword { get; set; }


        public static implicit operator WatchUser(RegisterModel registerModel)
        {
            return new WatchUser
            {
                FirstName = registerModel.Firstname,
                LastName = registerModel.Lastname,
                Livingplace = registerModel.Livingplace,
                Email = registerModel.Email,
                UserName = registerModel.Username
            };
        }
    }
}
