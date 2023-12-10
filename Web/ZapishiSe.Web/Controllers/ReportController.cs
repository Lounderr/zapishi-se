using Microsoft.AspNetCore.Mvc;
using ZapishiSe.Web.ViewModels.Default.Report;

namespace ZapishiSe.Web.Controllers
{
    public class ReportController : Controller
    {
        [HttpGet]
        public IActionResult Business(int businessId)
        {
            var viewModel = new BusinessViewModel();

            return View();
        }

        [HttpPost]
        public IActionResult Business(BusinessInputModel input)
        {
            return View();
        }

        [HttpGet]
        public IActionResult Review(int reviewId)
        {
            var viewModel = new ReviewViewModel();

            return View();
        }

        [HttpPost]
        public IActionResult Review(ReviewInputModel input)
        {
            return View();
        }

        [HttpGet]
        public IActionResult User(string userGuid)
        {
            var viewModel = new UserViewModel();

            return View();
        }

        [HttpPost]
        public IActionResult User(UserInputModel input)
        {
            return View();
        }
    }
}
