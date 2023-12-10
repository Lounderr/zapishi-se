using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using ZapishiSe.Web.ViewModels.Default.MyBookings;

namespace ZapishiSe.Web.Controllers
{
    [Authorize]
    public class MyBookingsController : Controller
    {
        public IActionResult Index()
        {
            var viewModel = new IndexViewModel();

            return View();
        }

        public IActionResult History()
        {
            var viewModel = new HistoryViewModel();

            return View();
        }

        [HttpPost]
        public IActionResult CancelBooking(int bookingId)
        {
            return RedirectToAction(nameof(Index));
        }
    }
}
