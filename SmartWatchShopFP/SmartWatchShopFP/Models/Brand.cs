using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace SmartWatchShopFP.Models
{
    public class Brand
    {
        public Brand()
        {
            Products = new HashSet<Product>();
        }
        public int Id { get; set; }
        [Required (ErrorMessage = "Brand Name cannot be empty")]
        [MinLength(2, ErrorMessage = "Brand Name must be at least {1} characters long")]
        [StringLength(150)]
        public string Name { get; set; }
        public bool Status { get; set; }

        public virtual ICollection<Product> Products { get; set; }
    }
}
