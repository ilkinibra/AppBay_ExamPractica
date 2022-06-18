using Microsoft.AspNetCore.Mvc;

namespace AppBay_BackEnd.Areas.Admin
{
    [Area("Admin")]
    public class DashboardController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
