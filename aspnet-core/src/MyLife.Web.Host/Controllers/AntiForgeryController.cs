using Microsoft.AspNetCore.Antiforgery;
using MyLife.Controllers;

namespace MyLife.Web.Host.Controllers
{
    public class AntiForgeryController : MyLifeControllerBase
    {
        private readonly IAntiforgery _antiforgery;

        public AntiForgeryController(IAntiforgery antiforgery)
        {
            _antiforgery = antiforgery;
        }

        public void GetToken()
        {
            _antiforgery.SetCookieTokenAndHeader(HttpContext);
        }
    }
}
