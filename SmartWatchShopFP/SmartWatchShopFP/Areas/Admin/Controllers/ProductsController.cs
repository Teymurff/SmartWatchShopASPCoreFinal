using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;
using SmartWatchShopFP.DAL;
using SmartWatchShopFP.ViewModels;
using System.Linq;
using System.Threading.Tasks;
using SmartWatchShopFP.Extensions;
using static SmartWatchShopFP.Extensions.IFormFileExstensions;
using Microsoft.AspNetCore.Http;
using System.Collections.Generic;
using SmartWatchShopFP.Models;
using System;
using Microsoft.AspNetCore.Authorization;

namespace SmartWatchShopFP.Areas.Admin.Controllers
{
    [Area("Admin")]
    [Authorize(Roles = "Admin,Moderator")]
    [Route("[area]/[controller]/[action]")]
    public class ProductsController : Controller
    {
        private readonly WatchContext _context;
        private readonly IHostingEnvironment _env;

        public object IFormFileExtensions { get; private set; }

        public ProductsController(WatchContext context, IHostingEnvironment env)
        {
            _context = context;
            _env = env;
        }

        public IActionResult Index()
        {
            HomePageVM homePageVM = new HomePageVM()
            {
                Products = _context.Products.Where(s => s.Status == true).Include(c => c.Images).Include(s=>s.Brand).ToList()
            };
            return View(homePageVM);
        }

        [HttpGet]
        public IActionResult Create()
        {
            HomePageVM homePageVM = new HomePageVM()
            {
                Product = new Models.Product()
            };

            ViewBag.Brands = new SelectList(_context.Brands, "Id", "Name");
            return View(homePageVM);
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create(HomePageVM homePageVM)
        {
            if (!ModelState.IsValid)
            {
                return View(homePageVM);
            }
            List<IFormFile> files = new List<IFormFile>();
            foreach (var item in homePageVM.ProductPhotos)
            {
                if (item == null)
                {
                    ModelState.AddModelError("ProductPhoto", "Image should be selected");
                    return View(homePageVM);
                }

                if (!item.IsImage())
                {
                    ModelState.AddModelError("ProductPhoto", "Image type is not valid");
                    return View(homePageVM);
                }

                if (!item.IsSmaller(1))
                {
                    ModelState.AddModelError("ProductPhoto", "Image size can be maximum 1 mb");
                    return View(homePageVM);
                }
                files.Add(item);

            }
            await _context.Products.AddAsync(new Product
            {
                Name = homePageVM.Product.Name,
                Price = homePageVM.Product.Price,
                HasDiscount = homePageVM.Product.HasDiscount,
                DiscountedPrice = homePageVM.Product.DiscountedPrice,
                Color = homePageVM.Product.Color,
                Availability = homePageVM.Product.Availability,
                Status = true,
                InStock = homePageVM.Product.InStock,
                BrandId = homePageVM.Product.BrandId
            });
            await _context.SaveChangesAsync();
            var ProId = _context.Products.LastOrDefault().Id;
            foreach (var item in files)
            {
                var Image = await item.SaveFileAsync(_env.WebRootPath, "images");
                await _context.Images.AddAsync(new Image
                {
                    ProductImage = Image,
                    ProductId = ProId
                });
                await _context.SaveChangesAsync();
            }
            return RedirectToAction(nameof(Index));
        }

        public async Task<IActionResult> Edit(int? id)
        {
            if (id == null) return NotFound();

             Product product = await _context.Products.FindAsync(id);
            var image = _context.Images.Where(i => i.ProductId == id).ToList();
            HomePageVM homePageVM = new HomePageVM()
            {
                Product = product,
                Images = image
            };

            if (homePageVM.Product == null) return NotFound();

            ViewBag.Brands = new SelectList(_context.Brands, "Id", "Name");
            return View(homePageVM);
        }

        [HttpPost, ValidateAntiForgeryToken]
        public async Task<IActionResult> Edit(HomePageVM homePageVM)
        {
           
            Product product = await _context.Products.FindAsync(homePageVM.Product.Id);
            var image = _context.Images.Where(i => i.ProductId == product.Id).ToList();
            HomePageVM homePageVMs = new HomePageVM()
            {
                Product = product,
                Images = image
            };
            if (!ModelState.IsValid)
            {
                return View(homePageVMs);
            }
            var productDb = await _context.Products.FindAsync(homePageVM.Product.Id);

            if (homePageVM.ProductPhotos != null)
            {
                try
                {
                    var ImgList = _context.Images.Where(v => v.ProductId == productDb.Id).ToList();
                    for (int i = 0; i < homePageVM.ProductPhotos.Count; i++)
                    {
                        IFormFileExstensions.Delete(_env.WebRootPath, "images",ImgList[i].ProductImage);

                        var newPhoto = await homePageVM.ProductPhotos[i].SaveFileAsync(_env.WebRootPath, "images");


                        ImgList[i].ProductImage = newPhoto;
                        _context.SaveChanges();
                    }
                }
                catch (Exception e)
                {
                    ModelState.AddModelError("", "Unexpected error happened while saving image. Please, try again.");
                    return View(homePageVMs);
                }
            }

            productDb.Name = homePageVM.Product.Name;
            productDb.Price = homePageVM.Product.Price;
            productDb.HasDiscount = homePageVM.Product.HasDiscount;
            productDb.DiscountedPrice = homePageVM.Product.DiscountedPrice;
            productDb.Color = homePageVM.Product.Color;
            productDb.Availability = homePageVM.Product.Availability;
            productDb.Status = true;
            productDb.InStock = homePageVM.Product.InStock;
            productDb.BrandId = homePageVM.Product.BrandId;

            await _context.SaveChangesAsync();

           return RedirectToAction(nameof(Index));
        }


        public async Task<IActionResult> Delete(int? id)
        {
            if (_context.Products.Count() <= 2)
            {
                return RedirectToAction(nameof(Index));
            }

            if (id == null) return NotFound();

            Product product = await _context.Products.FindAsync(id);
            var image = _context.Images.Where(i => i.ProductId == id).ToList();
            HomePageVM homePageVM = new HomePageVM()
            {
                Product = product,
                Images = image,
                Products = _context.Products.Include(s => s.Brand).ToList()
            };

            if (homePageVM.Product == null) return NotFound();

            return View(homePageVM);
        }

        [HttpPost, ValidateAntiForgeryToken]
        [ActionName("Delete")]
        public async Task<IActionResult> DeleteProduct(int? id)
        {
            if (id == null) return NotFound();

            Product product = await _context.Products.FindAsync(id);

            if (product == null) return NotFound();


            foreach (var item in product.Images)
            {
                IFormFileExstensions.Delete(_env.WebRootPath, "images", item.ProductImage);
            }
            product.Status = false;
            await _context.SaveChangesAsync();


            return RedirectToAction(nameof(Index));
        }
    }
}