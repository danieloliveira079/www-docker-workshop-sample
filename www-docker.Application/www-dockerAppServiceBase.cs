using Abp.Application.Services;

namespace www-docker
{
    /// <summary>
    /// Derive your application services from this class.
    /// </summary>
    public abstract class www-dockerAppServiceBase : ApplicationService
    {
        protected www-dockerAppServiceBase()
        {
            LocalizationSourceName = www-dockerConsts.LocalizationSourceName;
        }
    }
}