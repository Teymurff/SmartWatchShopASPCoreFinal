using System.ComponentModel.DataAnnotations;

namespace SmartWatchShopFP.ViewModels
{
    public class CreateRoleVM
    {
        [Required]
        [Display(Name = "Role")]
        public string RoleName { get; set; }
    }
}
