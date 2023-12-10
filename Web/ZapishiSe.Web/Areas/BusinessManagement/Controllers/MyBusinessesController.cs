using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using ZapishiSe.Common;
using ZapishiSe.Web.ViewModels.BusinessManagement.MyBusinesses;

namespace ZapishiSe.Web.Areas.ManageBusiness.Controllers
{
    [Area("BusinessManagement")]
    [Authorize(Roles = GlobalConstants.BusinessOwnerRoleName)]
    public class MyBusinessesController : Controller
    {
        [HttpGet]
        public IActionResult Index()
        {
            var viewModel = new IndexViewModel();
            return View();
        }

        [HttpGet]
        public IActionResult ById(int businessId)
        {
            var viewModel = new BusinessByIdViewModel();
            return View();
        }

        [HttpGet]
        public IActionResult Add()
        {
            return View();
        }

        [HttpPost]
        public IActionResult Add(AddBusinessInputModel input)
        {
            if (!ModelState.IsValid)
            {
                return this.View();
            }

            return RedirectToAction(nameof(Index));
        }

        [HttpGet]
        public IActionResult Edit(int businessId)
        {
            var viewModel = new EditBusinessViewModel();
            return View();
        }

        [HttpPost]
        public IActionResult Edit(EditBusinessInputModel input)
        {
            return RedirectToAction(nameof(Index));
        }

        [HttpGet]
        public IActionResult Remove(int businessId)
        {
            var viewModel = new RemoveBusinessViewModel();

            return View();
        }

        [HttpPost]
        public IActionResult Remove(RemoveBusinessInputModel input)
        {
            return RedirectToAction(nameof(Index));
        }

        [HttpPost]
        public IActionResult ToggleActivated(int businessId)
        {
            return Ok();
        }
    }
}
