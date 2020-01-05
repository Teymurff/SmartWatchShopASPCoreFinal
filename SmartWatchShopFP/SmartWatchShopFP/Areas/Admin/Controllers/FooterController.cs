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
    public class FooterController : Controller
    {
        private readonly WatchContext _context;
        public FooterController(WatchContext context)
        {
            _context = context;
        }
        public IActionResult Index()
        {
            return View(_context.Footers.FirstOrDefault());
        }

        public async Task<IActionResult> Edit(int? id)
        {
            if (id == null) return NotFound();

            Footer footer = await _context.Footers.FindAsync(id);

            if (footer == null) return NotFound();

            return View(footer);
        }

        [HttpPost, ValidateAntiForgeryToken]
        public async Task<IActionResult> Edit(Footer footer)
        {
            if (!ModelState.IsValid)
            {
                return View(footer);
            }
            var footerDb = await _context.Footers.FindAsync(footer.Id);

            footerDb.AddressFirstLine = footer.AddressFirstLine;
            footerDb.AddressSecondLine = footer.AddressSecondLine;
            footerDb.PhoneNumber = footer.PhoneNumber;
            footerDb.WorkingHours = footer.WorkingHours;
            footerDb.Email = footer.Email;

            await _context.SaveChangesAsync();

            return RedirectToAction(nameof(Index));
        }
    }
}