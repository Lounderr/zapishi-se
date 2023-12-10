using Microsoft.AspNetCore.Mvc;
using ZapishiSe.Web.ViewModels.Default.Business;

namespace ZapishiSe.Web.Controllers
{
    public class BusinessController : Controller
    {
        [HttpGet]
        public IActionResult Index(int businessId)
        {
            var viewModel = new IndexViewModel();

            return View();
        }
    }
}
