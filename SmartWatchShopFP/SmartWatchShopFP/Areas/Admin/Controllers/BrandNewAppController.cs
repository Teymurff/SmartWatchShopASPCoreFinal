using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.Mvc;
using SmartWatchShopFP.DAL;
using SmartWatchShopFP.Models;
using System.Linq;
using System.Threading.Tasks;
using static SmartWatchShopFP.Extensions.IFormFileExstensions;
using SmartWatchShopFP.Extensions;
using System;
using Microsoft.AspNetCore.Authorization;

namespace SmartWatchShopFP.Areas.Admin.Controllers
{
    [Area("Admin")]
    [Authorize(Roles = "Admin,Moderator")]
    [Route("[area]/[controller]/[action]")]
    public class BrandNewAppController : Controller
    {
        private readonly WatchContext _context;
        private readonly IHostingEnvironment _env;


        public BrandNewAppController(WatchContext context, IHostingEnvironment env)
        {
            _context = context;
            _env = env;
        }

        public IActionResult Index()
        {
            return View(_context.BrandNewApps.FirstOrDefault());
        }

        public async Task<IActionResult> Edit(int? id)
        {
            if (id == null) return NotFound();

            BrandNewApp brandNewApp  = await _context.BrandNewApps.FindAsync(id);

            if (brandNewApp == null) return NotFound();

            return View(brandNewApp);
        }

        [HttpPost, ValidateAntiForgeryToken]
        public async Task<IActionResult> Edit(BrandNewApp brandNewApp)
        {
            if (!ModelState.IsValid)
            {
                return View(brandNewApp);
            }
            var brandNewAppDb = await _context.BrandNewApps.FindAsync(brandNewApp.Id);

            if (brandNewApp.Photo != null)
            {
                try
                {
                    var newPhoto = await brandNewApp.Photo.SaveFileAsync(_env.WebRootPath, "images");

                    IFormFileExstensions.Delete(_env.WebRootPath, "images", brandNewAppDb.Image);

                    brandNewAppDb.Image = newPhoto;
                }
                catch (Exception e)
                {
                    ModelState.AddModelError("", "Unexpected error happened while saving image. Please, try again.");
                    return View(brandNewApp);
                }
            }

            if (brandNewApp.IconPhoto != null)
            {
                try
                {
                    var icoPhoto = await brandNewApp.IconPhoto.SaveFileAsync(_env.WebRootPath, "images");

                    IFormFileExstensions.Delete(_env.WebRootPath, "images", brandNewAppDb.IconImage);

                    brandNewAppDb.IconImage = icoPhoto;
                }
                catch (Exception e)
                {
                    ModelState.AddModelError("", "Unexpected error happened while saving image. Please, try again.");
                    return View(brandNewApp);
                }
            }

            brandNewAppDb.SubtitleTop = brandNewApp.SubtitleTop;
            brandNewAppDb.Title = brandNewApp.Title;
            brandNewAppDb.SubtitleBottom = brandNewApp.SubtitleBottom;
            brandNewAppDb.Paragraph = brandNewApp.Paragraph;
            brandNewAppDb.Button = brandNewApp.Button;



            await _context.SaveChangesAsync();

            return RedirectToAction(nameof(Index));
        }
    }
}
