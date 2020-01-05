using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.Mvc;
using SmartWatchShopFP.DAL;
using SmartWatchShopFP.Extensions;
using SmartWatchShopFP.Models;
using System.Threading.Tasks;
using static SmartWatchShopFP.Extensions.IFormFileExstensions;
using System;
using System.Linq;
using Microsoft.AspNetCore.Authorization;

namespace SmartWatchShopFP.Areas.Admin.Controllers
{
    [Area("Admin")]
    [Authorize(Roles = "Admin,Moderator")]
    [Route("[area]/[controller]/[action]")]
    public class SmartFutureController : Controller
    {
        private readonly WatchContext _context;
        private readonly IHostingEnvironment _env;
        public SmartFutureController(WatchContext context, IHostingEnvironment env)
        {
            _context = context;
            _env = env;
        }

        public IActionResult Index()
        {

            return View(_context.SmartFutures.FirstOrDefault());
        }

        public async Task<IActionResult> Edit(int? id)
        {
            if (id == null) return NotFound();

            SmartFuture smartFuture = await _context.SmartFutures.FindAsync(id);

            if (smartFuture == null) return NotFound();

            return View(smartFuture);
        }

        [HttpPost, ValidateAntiForgeryToken]
        public async Task<IActionResult> Edit(SmartFuture smartFuture)
        {
            if (!ModelState.IsValid)
            {
                return View(smartFuture);
            }
            var smartfutureDb = await _context.SmartFutures.FindAsync(smartFuture.Id);

            if (smartFuture.Photo != null)
            {
                try
                {
                    var newPhoto = await smartFuture.Photo.SaveFileAsync(_env.WebRootPath, "images");

                    IFormFileExstensions.Delete(_env.WebRootPath, "images", smartfutureDb.Image);

                    smartfutureDb.Image = newPhoto;
                }
                catch (Exception e)
                {
                    ModelState.AddModelError("", "Unexpected error happened while saving image. Please, try again.");
                    return View(smartFuture);
                }
            }

            smartfutureDb.Title = smartFuture.Title;
            smartfutureDb.Subtitle = smartFuture.Subtitle;
            smartfutureDb.Button = smartFuture.Button;


            await _context.SaveChangesAsync();

            return RedirectToAction(nameof(Index));
        }
    }
}