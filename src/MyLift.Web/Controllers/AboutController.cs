using System.Web.Mvc;

namespace MyLift.Web.Controllers
{
    public class AboutController : MyLiftControllerBase
    {
        public ActionResult Index()
        {
            return View();
        }
	}
}