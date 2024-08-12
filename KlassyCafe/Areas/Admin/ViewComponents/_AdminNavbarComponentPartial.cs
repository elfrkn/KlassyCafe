using Microsoft.AspNetCore.Mvc;

namespace KlassyCafe.Areas.Admin.ViewComponents
{
    public class _AdminNavbarComponentPartial : ViewComponent
    {
        public IViewComponentResult Invoke()
        {
            return View();
        }
    }
}
