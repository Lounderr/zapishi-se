using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using System.Net;
using ZapishiSe.Common;
using ZapishiSe.Web.ViewModels.BusinessManagement.ManageBooking;

namespace ZapishiSe.Web.Areas.ManageBusiness.Controllers
{
    [Area("BusinessManagement")]
    [Authorize(Roles = GlobalConstants.BusinessOwnerRoleName)]
    public class ManageBookingController : Controller
    {
        [HttpPost]
        public IActionResult ConfirmBooking(ConfirmBookingInputModel input)
        {
            return Ok();
        }

        [HttpPost]
        public IActionResult CancelBooking(CancelBookingInputModel input)
        {
            return Ok();
        }

        [HttpPost]
        public IActionResult BanClient(BanClientInputModel input)
        {
            return Ok();
        }
    }
}
