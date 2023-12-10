using Microsoft.AspNetCore.Mvc;
using ZapishiSe.Web.ViewModels.Default.Search;

namespace ZapishiSe.Web.Controllers
{
    public class SearchController : Controller
    {
        [HttpGet]
        [HttpPost]
        public IActionResult Index(SearchInputModel input)
        {
            return View();
        }
    }
}
