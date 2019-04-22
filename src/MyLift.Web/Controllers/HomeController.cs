using System.Web.Mvc;
using Abp.Web.Mvc.Authorization;

namespace MyLift.Web.Controllers
{
    [AbpMvcAuthorize]
    public class HomeController : MyLiftControllerBase
    {
        public ActionResult Index()
        {
            return View();
        }
	}
}