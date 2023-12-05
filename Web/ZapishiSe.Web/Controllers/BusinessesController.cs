using Microsoft.AspNetCore.Mvc;

namespace ZapishiSe.Web.Controllers
{
    public class BusinessesController : Controller
    {
        public IActionResult Search()
        {
            return View();
        }

        public IActionResult Search(string[] keywords, string city)
        {
            return View();
        }


        public IActionResult ById(int id)
        {
            return View();
        }

        public IActionResult Book(int id)
        {
            return View();
        }

        public IActionResult LeaveReview(int id)
        {
            return View();
        }

        public IActionResult ReportBusiness(int id)
        {
            return View();
        }

        public IActionResult ReportReview(int reviewId)
        {
            return View();
        }
    }
}
