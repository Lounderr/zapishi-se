using Microsoft.AspNetCore.Mvc;

namespace ZapishiSe.Web.Controllers
{
    public class ServicesController : Controller
    {
        public IActionResult Index()
        {
            this.ViewData["isWhite"] = true;

            return View();
        }
    }
}
