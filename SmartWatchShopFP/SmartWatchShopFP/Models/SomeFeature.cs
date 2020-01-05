using System.ComponentModel.DataAnnotations;

namespace SmartWatchShopFP.Models
{
    public class SomeFeature
    {
        public int Id { get; set; }

        [Required(ErrorMessage = "Title cannot be empty")]
        [MinLength(3, ErrorMessage = "Title must be at least {1} characters long")]
        [StringLength(150)]
        public string Title { get; set; }

        [Required(ErrorMessage = "Paragraph cannot be empty")]
        [MinLength(30, ErrorMessage = "Paragraph must be at least {1} characters long")]
        [StringLength(300)]
        public string Paragraph { get; set; }

        [Required(ErrorMessage = "Icon cannot be empty")]
        [MinLength(3, ErrorMessage = "Icon must be at least {1} characters long")]
        [StringLength(100)]
        public string Icon { get; set; }

    }
}
