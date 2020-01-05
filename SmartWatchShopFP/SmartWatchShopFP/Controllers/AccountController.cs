using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using SmartWatchShopFP.DAL;
using SmartWatchShopFP.Extensions;
using SmartWatchShopFP.Models;
using SmartWatchShopFP.ViewModels;
using System.Threading.Tasks;

namespace SmartWatchShopFP.Controllers
{
    [AllowAnonymous]
    public class AccountController : Controller
    {
        private readonly WatchContext _context;
        private readonly UserManager<WatchUser> _userManager;
        private readonly SignInManager<WatchUser> _signInManager;
        private readonly RoleManager<IdentityRole> _roleManager;
        public AccountController(WatchContext context, UserManager<WatchUser> userManager,
            SignInManager<WatchUser> signInManager, RoleManager<IdentityRole> roleManager)
        {
            _context = context;
            _userManager = userManager;
            _signInManager = signInManager;
            _roleManager = roleManager;
        }

        public IActionResult Register()
        {
            return View();
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Register(RegisterModel registerModel)
        {
            if (!ModelState.IsValid)
            {
                return View(registerModel);
            }

            WatchUser user = registerModel;

            IdentityResult result = await _userManager.CreateAsync(user, registerModel.Password);

            if (!result.Succeeded)
            {
                foreach (var error in result.Errors)
                {
                    ModelState.AddModelError("", error.Description);
                }

                return View(registerModel);
            }

            return RedirectToAction("Index", "Home");
        }
        [AllowAnonymous]
        public IActionResult Login()
        {

            return View();
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        [AllowAnonymous]
        public async Task<IActionResult> Login(LoginModel loginModel)
        {
            if (!ModelState.IsValid)
            {
                return View(loginModel);
            }

            WatchUser user = await _userManager.FindByEmailAsync(loginModel.EmailOrUsername);

            if (user == null)
            {
                user = await _userManager.FindByNameAsync(loginModel.EmailOrUsername);
            }

            if (user == null)
            {
                ModelState.AddModelError("", "Email or password is invalid");
                return View(loginModel);
            }

            var result = await _signInManager.PasswordSignInAsync(user, loginModel.Password, loginModel.RememberMe, false);

            if (result.Succeeded)
            {
                return RedirectToAction("Index", "Home");
            }

            ModelState.AddModelError("", "Email or password is invalid");
            return View(loginModel);
        }

        public async Task<IActionResult> Logout()
        {
            await _signInManager.SignOutAsync();

            return RedirectToAction("Index", "Home");
        }

        //public async Task RoleSeeder()
        //{
        //    if (!await _roleManager.RoleExistsAsync(IFormFileExstensions.Roles.Admin.ToString()))
        //    {
        //        await _roleManager.CreateAsync(new IdentityRole(IFormFileExstensions.Roles.Admin.ToString()));
        //    }

        //    if (!await _roleManager.RoleExistsAsync(IFormFileExstensions.Roles.Member.ToString()))
        //    {
        //        await _roleManager.CreateAsync(new IdentityRole(IFormFileExstensions.Roles.Member.ToString()));
        //    }
        //}

    }
}