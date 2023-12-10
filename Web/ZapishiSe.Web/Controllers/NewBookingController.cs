using Microsoft.AspNetCore.Mvc;
using ZapishiSe.Web.ViewModels.Default.NewBooking;

namespace ZapishiSe.Web.Controllers
{
    public class NewBookingController : Controller
    {
        [HttpGet]
        public IActionResult Index(int businessId)
        {
            return View();
        }

        [HttpPost]
        public IActionResult Index(IndexInputModel input)
        {
            return View();
        }
    }
}
