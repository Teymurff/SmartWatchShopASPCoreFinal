using System.ComponentModel.DataAnnotations;

namespace SmartWatchShopFP.Models
{
    public class Faq
    {
        public int Id { get; set; }

        [Required(ErrorMessage = "Question cannot be empty")]
        [MinLength(5, ErrorMessage = "Question must be at least {1} characters long")]
        [StringLength(500)]
        public string Question { get; set; }

        [Required(ErrorMessage = "Answer cannot be empty")]
        [MinLength(10, ErrorMessage = "Answer must be at least {1} characters long")]
        [StringLength(500)]
        public string Answer { get; set; }
    }
}
