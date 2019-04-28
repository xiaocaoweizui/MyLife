using Abp.AspNetCore.Mvc.Controllers;
using Abp.IdentityFramework;
using Microsoft.AspNetCore.Identity;

namespace MyLife.Controllers
{
    public abstract class MyLifeControllerBase: AbpController
    {
        protected MyLifeControllerBase()
        {
            LocalizationSourceName = MyLifeConsts.LocalizationSourceName;
        }

        protected void CheckErrors(IdentityResult identityResult)
        {
            identityResult.CheckErrors(LocalizationManager);
        }
    }
}
