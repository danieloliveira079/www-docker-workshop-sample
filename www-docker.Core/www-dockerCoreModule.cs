using System.Reflection;
using Abp.Modules;

namespace www-docker
{
    public class www-dockerCoreModule : AbpModule
    {
        public override void Initialize()
        {
            IocManager.RegisterAssemblyByConvention(Assembly.GetExecutingAssembly());
        }
    }
}
