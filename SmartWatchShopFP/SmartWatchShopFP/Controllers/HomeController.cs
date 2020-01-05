using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;
using SmartWatchShopFP.DAL;
using SmartWatchShopFP.ViewModels;
using System.Linq;

namespace SmartWatchShopFP.Controllers
{
    [AllowAnonymous]
    public class HomeController : Controller
    {
        private readonly WatchContext _context;
        public HomeController(WatchContext context)
        {
            _context = context;
        }
        public IActionResult Index()
        {
            HomePageVM homePageVM = new HomePageVM()
            {
                Brands = _context.Brands.Where(s=>s.Status == true).ToList(),
                Products = _context.Products.Include(c=>c.Images).Take(4).ToList(),
                SmartFuture=_context.SmartFutures.FirstOrDefault(),
                BrandNewApp = _context.BrandNewApps.FirstOrDefault(),
                SomeFeatures = _context.SomeFeatures.ToList(),
                GloballyConnected = _context.GloballyConnecteds.FirstOrDefault(),
                Faqs = _context.Faqs.ToList()
            };
            ViewBag.Brands = new SelectList(_context.Brands.Where(s=>s.Status == true), "Id", "Name");
            return View(homePageVM);
        }

        public IActionResult OurProducts()
        {
            HomePageVM homePageVM = new HomePageVM()
            {
                Brands = _context.Brands.Where(s => s.Status == true).ToList(),
                Products = _context.Products.Include(c => c.Images).Take(4).ToList()
            };
            ViewBag.Brands = new SelectList(_context.Brands.Where(s => s.Status == true), "Id", "Name");
            ViewData["total_products_count"] = _context.Products.Count();
            return View(homePageVM);
        }

        public IActionResult ProductDetails(int id)
        {
            HomePageVM homePageVM = new HomePageVM()
            {
                Images = _context.Images.Where(v => v.ProductId == id).ToList(),
                Product = _context.Products.Include(p => p.Brand).Where(x => x.BrandId == x.Brand.Id).FirstOrDefault(v => v.Id == id)
            };

            return View(homePageVM);
        }
    }
}
