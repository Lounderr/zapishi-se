namespace ZapishiSe.Web.Controllers
{
    using Microsoft.AspNetCore.Mvc;
    using System.Diagnostics;
    using ZapishiSe.Web.ViewModels;
    using ZapishiSe.Web.ViewModels.Default.Home;
    using ZapishiSe.Web.ViewModels.Default.Search;

    public class HomeController : BaseController
    {
        public IActionResult Index()
        {
            return this.View();
        }

        [HttpPost]
        public IActionResult Index(SearchViewModel input)
        {
            return RedirectToAction(nameof(SearchController.Index), "Search", input);
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
