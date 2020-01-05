using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using SmartWatchShopFP.DAL;
using SmartWatchShopFP.Models;
using System.Linq;
using System.Threading.Tasks;

namespace SmartWatchShopFP.Areas.Admin.Controllers
{
    [Area("Admin")]
    [Authorize(Roles = "Admin,Moderator")]
    [Route("[area]/[controller]/[action]")]
    public class SomeFeatureController : Controller
    {
        private readonly WatchContext _context;
        public SomeFeatureController(WatchContext context)
        {
            _context = context;
        }

        public IActionResult Index()
        {
            return View(_context.SomeFeatures.ToList());
        }

        public async Task<IActionResult> Edit(int? id)
        {
            if (id == null) return NotFound();

            SomeFeature someFeature = await _context.SomeFeatures.FindAsync(id);

            if (someFeature == null) return NotFound();

            return View(someFeature);
        }

        [HttpPost, ValidateAntiForgeryToken]
        public async Task<IActionResult> Edit(SomeFeature someFeature)
        {
            if (!ModelState.IsValid)
            {
                return View(someFeature);
            }
            var someFeatureDb = await _context.SomeFeatures.FindAsync(someFeature.Id);

            someFeatureDb.Title = someFeature.Title;
            someFeatureDb.Paragraph = someFeature.Paragraph;
            someFeatureDb.Icon = someFeature.Icon;

            await _context.SaveChangesAsync();

            return RedirectToAction(nameof(Index));
        }
    }
}