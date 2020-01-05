using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using SmartWatchShopFP.DAL;
using SmartWatchShopFP.ViewModels;
using System.Linq;
using System.Threading.Tasks;

namespace SmartWatchShopFP.Controllers
{
    [AllowAnonymous]
    public class AjaxController : Controller
    {
        private readonly WatchContext _context;
        public AjaxController(WatchContext context)
        {
            _context = context;
        }

        [HttpPost]
        public async Task<IActionResult> GetProductBrand(int id)
        {
            if (id == 0)
            {
                return PartialView("_BrandProductPartial", new HomePageVM { Products = _context.Products.ToList(), Images = _context.Images.ToList() });
            }
            var brand = await _context.Brands.Include(s => s.Products).FirstOrDefaultAsync(c => c.Id == id);

            return PartialView("_BrandProductPartial", new HomePageVM { Products = brand.Products.ToList(), Images = _context.Images.ToList() });
        }

        [HttpPost]
        public IActionResult LoadMoreProducts(int count)
        {
            return PartialView("_BrandProductPartial", new HomePageVM
            {
                Products = _context.Products.Where(w => w.Status == true).Skip(count).Take(4).ToList(),
                Images = _context.Images.ToList()
            });
        }

    }
}