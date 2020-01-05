using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.Mvc;
using SmartWatchShopFP.DAL;
using SmartWatchShopFP.Extensions;
using SmartWatchShopFP.Models;
using System;
using System.Linq;
using System.Threading.Tasks;
using static SmartWatchShopFP.Extensions.IFormFileExstensions;


namespace SmartWatchShopFP.Areas.Admin.Controllers
{
    [Area("Admin")]
    [Authorize(Roles = "Admin,Moderator")]
    [Route("[area]/[controller]/[action]")]
    public class GloballyConnectedController : Controller
    {
        private readonly WatchContext _context;
        private readonly IHostingEnvironment _env;

        public GloballyConnectedController(WatchContext context, IHostingEnvironment env)
        {
            _context = context;
            _env = env;
        }
        public IActionResult Index()
        {
            return View(_context.GloballyConnecteds.FirstOrDefault());
        }

        public async Task<IActionResult> Edit(int? id)
        {
            if (id == null) return NotFound();

            GloballyConnected globallyConnected = await _context.GloballyConnecteds.FindAsync(id);

            if (globallyConnected == null) return NotFound();

            return View(globallyConnected);
        }

        [HttpPost, ValidateAntiForgeryToken]
        public async Task<IActionResult> Edit(GloballyConnected globallyConnected)
        {
            if (!ModelState.IsValid)
            {
                return View(globallyConnected);
            }
            var globallyConnectedDb = await _context.GloballyConnecteds.FindAsync(globallyConnected.Id);

            if (globallyConnected.Photo != null)
            {
                try
                {
                    var newPhoto = await globallyConnected.Photo.SaveFileAsync(_env.WebRootPath, "images");

                    IFormFileExstensions.Delete(_env.WebRootPath, "images", globallyConnectedDb.Image);

                    globallyConnectedDb.Image = newPhoto;
                }
                catch (Exception e)
                {
                    ModelState.AddModelError("", "Unexpected error happened while saving image. Please, try again.");
                    return View(globallyConnected);
                }
            }

            globallyConnectedDb.Title = globallyConnected.Title;
            globallyConnectedDb.Subtitle = globallyConnected.Subtitle;
            globallyConnectedDb.Paragraph = globallyConnected.Paragraph;
            globallyConnectedDb.Button = globallyConnected.Button;

            await _context.SaveChangesAsync();

            return RedirectToAction(nameof(Index));
        }
    }
}