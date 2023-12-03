using Microsoft.AspNetCore.Mvc;

namespace ZapishiSe.Web.Controllers
{
    public class BusinessesController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }

        public IActionResult Business(int id)
        {

            return View();
        }
    }
}
