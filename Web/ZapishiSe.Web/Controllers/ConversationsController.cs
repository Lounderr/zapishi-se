using Microsoft.AspNetCore.Mvc;

namespace ZapishiSe.Web.Controllers
{
    public class ConversationsController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }

        public IActionResult Conversation(string conversationGuid)
        {
            return View();
        }
    }
}
