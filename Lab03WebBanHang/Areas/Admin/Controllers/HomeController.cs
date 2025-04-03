using Microsoft.AspNetCore.Mvc;

namespace TranTrungDung_2280600423_Lab03WebBanHang.Areas.Admin.Controllers
{
    [Area("Admin")]
    public class HomeController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
