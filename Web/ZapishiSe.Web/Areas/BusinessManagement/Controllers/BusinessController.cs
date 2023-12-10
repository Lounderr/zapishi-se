using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using ZapishiSe.Common;
using ZapishiSe.Web.ViewModels.BusinessManagement.Business;

namespace ZapishiSe.Web.Areas.ManageBusiness.Controllers
{
    [Area("BusinessManagement")]
    [Authorize(Roles = GlobalConstants.BusinessOwnerRoleName)]
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
