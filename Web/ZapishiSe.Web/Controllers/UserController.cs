using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;

namespace ZapishiSe.Web.Controllers
{
    public class UserController : Controller
    {
        public IActionResult Index(string userGuid)
        {
            return View();
        }
    }
}
