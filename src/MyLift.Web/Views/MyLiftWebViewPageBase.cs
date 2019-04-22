using Abp.Web.Mvc.Views;

namespace MyLift.Web.Views
{
    public abstract class MyLiftWebViewPageBase : MyLiftWebViewPageBase<dynamic>
    {

    }

    public abstract class MyLiftWebViewPageBase<TModel> : AbpWebViewPage<TModel>
    {
        protected MyLiftWebViewPageBase()
        {
            LocalizationSourceName = MyLiftConsts.LocalizationSourceName;
        }
    }
}