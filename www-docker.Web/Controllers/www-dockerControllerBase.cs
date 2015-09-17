using Abp.Web.Mvc.Controllers;

namespace www-docker.Web.Controllers
{
    /// <summary>
    /// Derive all Controllers from this class.
    /// </summary>
    public abstract class www-dockerControllerBase : AbpController
    {
        protected www-dockerControllerBase()
        {
            LocalizationSourceName = www-dockerConsts.LocalizationSourceName;
        }
    }
}