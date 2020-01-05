using Microsoft.AspNetCore.Http;
using SmartWatchShopFP.Models;
using System.Collections.Generic;


namespace SmartWatchShopFP.ViewModels
{
    public class HomePageVM
    {
        public List<Brand> Brands { get; set; }
        public List<Product> Products { get; set; }
        public SmartFuture SmartFuture { get; set; }
        public BrandNewApp BrandNewApp { get; set; }
        public List<SomeFeature> SomeFeatures { get; set; }
        public GloballyConnected GloballyConnected { get; set; }
        public List<Faq> Faqs { get; set; }
        public Product Product { get; set; }
        public Image Image { get; set; }
        public List<Image> Images { get; set; }
        public List<IFormFile> ProductPhotos { get; set; }   
    }
}
