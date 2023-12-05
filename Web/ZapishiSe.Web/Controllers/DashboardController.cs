using Microsoft.AspNetCore.Mvc;

namespace ZapishiSe.Web.Controllers
{
    public class DashboardController : Controller
    {
        public IActionResult Index(int id)
        {
            return View();
        }

        public IActionResult CancelBooking(int id)
        {
            return View();
        }

        public IActionResult BanClient(int id)
        {
            return View();
        }
    }
}
