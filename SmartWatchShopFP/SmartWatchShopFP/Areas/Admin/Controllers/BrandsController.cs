using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using SmartWatchShopFP.DAL;
using SmartWatchShopFP.Models;
using SmartWatchShopFP.ViewModels;
using System.Linq;
using System.Threading.Tasks;

namespace SmartWatchShopFP.Areas.Admin.Controllers
{
    [Area("Admin")]
    [Authorize(Roles = "Admin,Moderator")]
    [Route("[area]/[controller]/[action]")]
    public class BrandsController : Controller
    {
        private readonly WatchContext _context;

        public BrandsController(WatchContext context)
        {
            _context = context;
        }

        public IActionResult Index()
        {
            HomePageVM homePageVM = new HomePageVM()
            {
                Brands = _context.Brands.Where(s=>s.Status == true).ToList()
            };
            return View(homePageVM);
        }

        [HttpGet]
        public IActionResult Create()
        {

            return View();
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create(Brand brand)
        {

            if (!ModelState.IsValid)
            {
                return View(brand);
            }
            brand.Status = true;
            await _context.Brands.AddAsync(brand);
            await _context.SaveChangesAsync();

            return RedirectToAction(nameof(Index));
        }

        public async Task<IActionResult> Edit(int? id)
        {
            if (id == null) return NotFound();

            Brand brand = await _context.Brands.FindAsync(id);

            if (brand == null) return NotFound();

            return View(brand);
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Edit(Brand brand)
        {
            if (!ModelState.IsValid)
            {
                return View(brand);
            }
            var brandDb = await _context.Brands.FindAsync(brand.Id);


            brandDb.Name = brand.Name;

            await _context.SaveChangesAsync();


            return RedirectToAction(nameof(Index));
        }

        public async Task<IActionResult> Delete(int? id)
        {
            if (_context.Brands.Count() <= 2)
            {
                return RedirectToAction(nameof(Index));
            }

            if (id == null) return NotFound();

            Brand brand = await _context.Brands.FindAsync(id);

            if (brand == null) return NotFound();

            return View(brand);
        }

        [HttpPost, ValidateAntiForgeryToken]
        [ActionName("Delete")]
        public async Task<IActionResult> DeleteBrand(int? id)
        {
            if (id == null) return NotFound();
            Brand brand = await _context.Brands.FindAsync(id);
            if (brand == null) return NotFound();

            brand.Status = false;
            await _context.SaveChangesAsync();
            return RedirectToAction(nameof(Index));
        }

    }
}