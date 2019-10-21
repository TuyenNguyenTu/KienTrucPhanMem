using System.Web.Mvc;
using Abp.Web.Mvc.Authorization;

namespace Project.KienTrucPhanMem.Web.Controllers
{
    [AbpMvcAuthorize]
    public class HomeController : KienTrucPhanMemControllerBase
    {
        public ActionResult Index()
        {
            return View("~/App/Main/views/layout/layout.cshtml"); //Layout of the angular application.
        }
	}
}