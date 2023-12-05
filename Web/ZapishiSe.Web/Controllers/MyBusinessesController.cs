using Microsoft.AspNetCore.Mvc;

namespace ZapishiSe.Web.Controllers
{
    public class MyBusinessesController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }

        public IActionResult ById(int id)
        {
            return View();
        }

        public IActionResult Add(int id)
        {
            return View();
        }

        public IActionResult Edit(int id)
        {
            return View();
        }

        public IActionResult Remove(int id)
        {
            return View();
        }
    }
}
