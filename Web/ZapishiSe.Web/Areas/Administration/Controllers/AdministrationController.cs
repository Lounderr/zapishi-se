namespace ZapishiSe.Web.Areas.Administration.Controllers
{
    using ZapishiSe.Common;
    using ZapishiSe.Web.Controllers;

    using Microsoft.AspNetCore.Authorization;
    using Microsoft.AspNetCore.Mvc;

    [Authorize(Roles = GlobalConstants.AdministratorRoleName)]
    [Area("Administration")]
    public class AdministrationController : BaseController
    {
    }
}
