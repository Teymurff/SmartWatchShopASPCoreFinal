using Microsoft.AspNetCore.Http;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace SmartWatchShopFP.Models
{
    public class SmartFuture
    {
        public int Id { get; set; }

        [StringLength(300)]
        public string Image { get; set; }

        [Required(ErrorMessage = "Subtitle cannot be empty")]
        [MinLength(3, ErrorMessage = "Subtitle must be at least {1} characters long")]
        [StringLength(150)]
        public string Subtitle { get; set; }

        [Required(ErrorMessage = "Title cannot be empty")]
        [MinLength(5, ErrorMessage = "Title must be at least {1} characters long")]
        [StringLength(150)]
        public string Title { get; set; }

        [Required(ErrorMessage = "Button cannot be empty")]
        [MinLength(3, ErrorMessage = "Button must be at least {1} characters long")]
        [StringLength(150)]
        public string Button { get; set; }

        [NotMapped]
        public IFormFile Photo { get; set; }
    }
}
