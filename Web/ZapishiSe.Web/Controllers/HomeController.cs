namespace ZapishiSe.Web.Controllers
{
    using Microsoft.AspNetCore.Mvc;
    using System.Diagnostics;
    using ZapishiSe.Web.ViewModels;
    using ZapishiSe.Web.ViewModels.Default.Home;

    public class HomeController : BaseController
    {
        public IActionResult Index()
        {
            var viewModel = new IndexViewModel();

            return this.View();
        }

        [HttpGet]
        public IActionResult ContactUs()
        {
            return this.View();
        }

        [HttpPost]
        public IActionResult ContactUs(ContactUsInputModel input)
        {
            return this.View();
        }

        public IActionResult Privacy()
        {
            return this.View();
        }

        public IActionResult Tos()
        {
            return this.View();
        }

        public IActionResult PostReviewTos()
        {
            return this.View();
        }

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return this.View(
                new ErrorViewModel { RequestId = Activity.Current?.Id ?? this.HttpContext.TraceIdentifier });
        }
    }
}
