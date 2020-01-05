using Microsoft.AspNetCore.Http;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace SmartWatchShopFP.Models
{
    public class BrandNewApp
    {
        public int Id { get; set; }

        [StringLength(300)]
        public string Image { get; set; }

        [StringLength(300)]
        public string IconImage { get; set; }

        [Required(ErrorMessage = "SubtitleTop cannot be empty")]
        [MinLength(5, ErrorMessage = "SubtitleTop must be at least {1} characters long")]
        [StringLength(150)]
        public string SubtitleTop { get; set; }

        [Required(ErrorMessage = "Title cannot be empty")]
        [MinLength(5, ErrorMessage = "Title must be at least {1} characters long")]
        [StringLength(150)]
        public string Title { get; set; }

        [Required(ErrorMessage = "SubtitleBottom cannot be empty")]
        [MinLength(5, ErrorMessage = "SubtitleBottom must be at least {1} characters long")]
        [StringLength(150)]
        public string SubtitleBottom { get; set; }

        [Required(ErrorMessage = "Paragraph cannot be empty")]
        [MinLength(50, ErrorMessage = "Paragraph must be at least {1} characters long")]
        [StringLength(300)]
        public string Paragraph { get; set; }

        [Required(ErrorMessage = "Button cannot be empty")]
        [MinLength(5, ErrorMessage = "Button must be at least {1} characters long")]
        [StringLength(150)]
        public string Button { get; set; }

        [NotMapped]
        public IFormFile Photo { get; set; }

        [NotMapped]
        public IFormFile IconPhoto { get; set; }
    }
}
