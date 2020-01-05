using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using Newtonsoft.Json;
using SmartWatchShopFP.DAL;
using SmartWatchShopFP.Models;
using SmartWatchShopFP.ViewModels;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace SmartWatchShopFP.Controllers
{
    [AllowAnonymous]
    public class CartController : Controller
    {
        private readonly WatchContext _context;

        public CartController(WatchContext context)
        {
            _context = context;
        }

        public IActionResult ProductCart()
        {
            List<CartItem> cart = new List<CartItem>();
            string cartString = HttpContext.Session.GetString("cart");

            if (cartString != null)
            {
                cart = JsonConvert.DeserializeObject<List<CartItem>>(cartString);

            }

            return View(cart);
        }

        public async Task<IActionResult> AddToCart(int id)
        {
            var cart = new List<CartItem>();

            var cartSession = HttpContext.Session.GetString("cart");

            if (cartSession != null)
            {
                cart = JsonConvert.DeserializeObject<List<CartItem>>(cartSession);

                if (cart.Any(c => c.Product.Id == id))
                {
                    CartItem cardItem = cart.First(c => c.Product.Id == id);
                    cardItem.Count++;
                }
                else
                {
                    cart.Add(new CartItem
                    {

                        Product = await _context.Products.FindAsync(id),
                        Photo = _context.Images.Where(v => v.ProductId == id).Select(v => v.ProductImage).ToList(),

                        Count = 1
                    });

                }
            }
            else
            {
                cart.Add(new CartItem
                {

                    Product = await _context.Products.FindAsync(id),
                    Photo = _context.Images.Where(v => v.ProductId == id).Select(v => v.ProductImage).ToList(),
                    Count = 1
                });

            }

            string jsonList = JsonConvert.SerializeObject(cart);
            HttpContext.Session.SetString("cart", jsonList);

            return Json(new
            {
                status = 200,
                message = "Product was successfully added to cart",
                data = cart.Sum(c => c.Count)
            });
        }

        public IActionResult Checkout()
        {
            List<CartItem> cart = new List<CartItem>();
            string cartString = HttpContext.Session.GetString("cart");

            if (cartString != null)
            {
                cart = JsonConvert.DeserializeObject<List<CartItem>>(cartString);

            }

            return View(cart);
        }

        public IActionResult RemoveCart(int id)
        {
            string cartString = HttpContext.Session.GetString("cart");

            var cartObject = JsonConvert.DeserializeObject<List<CartItem>>(cartString);
            var removeCart = cartObject.FirstOrDefault(c => c.Product.Id == id);

            cartObject.Remove(removeCart);
            var cartDone = JsonConvert.SerializeObject(cartObject);
            HttpContext.Session.SetString("cart", cartDone);

            return RedirectToAction(nameof(ProductCart));
        }
    }
}