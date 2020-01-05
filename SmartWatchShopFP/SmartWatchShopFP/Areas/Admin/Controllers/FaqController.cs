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
    public class FaqController : Controller
    {
        private readonly WatchContext _context;
        public FaqController(WatchContext context)
        {
            _context = context;
        }
        public IActionResult Index()
        {
            return View(_context.Faqs.ToList());
        }

        public async Task<IActionResult> Edit(int? id)
        {
            if (id == null) return NotFound();

            Faq faq = await _context.Faqs.FindAsync(id);

            if (faq == null) return NotFound();

            return View(faq);
        }

        [HttpPost, ValidateAntiForgeryToken]
        public async Task<IActionResult> Edit(Faq faq)
        {
            if (!ModelState.IsValid)
            {
                return View(faq);
            }
            var faqDb = await _context.Faqs.FindAsync(faq.Id);

            faqDb.Question = faq.Question;
            faqDb.Answer = faq.Answer;

            await _context.SaveChangesAsync();

            return RedirectToAction(nameof(Index));
        }
    }
}