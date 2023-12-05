using Microsoft.AspNetCore.Mvc;

namespace ZapishiSe.Web.Controllers
{
    public class Users : Controller
    {
        public IActionResult Index(int guid)
        {
            return View();
        }
    }
}
