using Microsoft.AspNetCore.Http;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace SmartWatchShopFP.Models
{
    public class Image
    {
        public int Id { get; set; }

        [StringLength(300)]
        public string ProductImage { get; set; }
        [NotMapped]
        public IFormFile ProductPhoto { get; set; }

        public int ProductId { get; set; }

        public virtual Product Product { get; set; }
    }
}
