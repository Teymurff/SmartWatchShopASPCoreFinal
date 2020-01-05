using Microsoft.AspNetCore.Mvc;
using SmartWatchShopFP.DAL;
using System.Linq;
using System.Threading.Tasks;

namespace SmartWatchShopFP.Components
{
    public class FooterViewComponent : ViewComponent
    {
        private readonly WatchContext _context;
        public FooterViewComponent(WatchContext context)
        {
            _context = context;
        }

        public async Task<IViewComponentResult> InvokeAsync()
        {
            var footer = _context.Footers.FirstOrDefault();
            return View(await Task.FromResult(footer));
        }
    }
}
