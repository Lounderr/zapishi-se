using Microsoft.AspNetCore.Mvc;

namespace ZapishiSe.Web.Controllers
{
    public class MyBookingsController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }

        public IActionResult History()
        {
            return View();
        }

        public IActionResult CancelBooking(int id)
        {
            return View();
        }
    }
}
