namespace LuckyBalls.Web.Areas.Administration.Controllers
{
    using LuckyBalls.Common;
    using LuckyBalls.Web.Controllers;

    using Microsoft.AspNetCore.Authorization;
    using Microsoft.AspNetCore.Mvc;

    [Authorize(Roles = GlobalConstants.AdministratorRoleName)]
    [Area("Administration")]
    public class AdministrationController : BaseController
    {
    }
}
