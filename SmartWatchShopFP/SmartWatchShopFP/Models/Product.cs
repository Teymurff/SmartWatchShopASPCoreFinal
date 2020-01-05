using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace SmartWatchShopFP.Models
{
    public class Product
    {
        public Product()
        {
            Images = new HashSet<Image>();
        }

        public int Id { get; set; }

        [Required(ErrorMessage = "Product Name cannot be empty")]
        [MinLength(5, ErrorMessage = "Product Name must be at least {1} characters long")]
        [StringLength(150)]
        public string Name { get; set; }

        [Required(ErrorMessage = "Product Price cannot be empty")]
        public decimal Price { get; set; }

        public bool HasDiscount { get; set; }

        public decimal DiscountedPrice { get; set; }

        [Required(ErrorMessage = "Product Color cannot be empty")]
        [MinLength(3, ErrorMessage = "Product Color must be at least {1} characters long")]
        [StringLength(150)]
        public string Color { get; set; }

        [Required(ErrorMessage = "Product Availability cannot be empty")]
        [MinLength(5, ErrorMessage = "Product Availability must be at least {1} characters long")]
        [StringLength(150)]
        public string Availability { get; set; }

        public bool Status { get; set; }

        public bool InStock { get; set; }

        public int BrandId { get; set; }

        public virtual Brand Brand { get; set; }

        public virtual ICollection<Image> Images { get; set; }

    }

}
