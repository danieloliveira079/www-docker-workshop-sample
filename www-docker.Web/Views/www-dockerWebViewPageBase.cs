using Abp.Web.Mvc.Views;

namespace www-docker.Web.Views
{
    public abstract class www-dockerWebViewPageBase : www-dockerWebViewPageBase<dynamic>
    {

    }

    public abstract class www-dockerWebViewPageBase<TModel> : AbpWebViewPage<TModel>
    {
        protected www-dockerWebViewPageBase()
        {
            LocalizationSourceName = www-dockerConsts.LocalizationSourceName;
        }
    }
}