using Microsoft.AspNetCore.Http;
using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace SmartWatchShopFP.Models
{
    public class CartItem
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public decimal Price { get; set; }
        public bool HasDiscount { get; set; }
        public decimal DiscountedPrice { get; set; }
        public byte Count { get; set; }
        public IEnumerable<string> Photo { get; set; }
        public Product Product { get; set; }
    }
}
