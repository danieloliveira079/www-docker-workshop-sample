using System.Reflection;
using Abp.Modules;

namespace www-docker
{
    [DependsOn(typeof(www-dockerCoreModule))]
    public class www-dockerApplicationModule : AbpModule
    {
        public override void Initialize()
        {
            IocManager.RegisterAssemblyByConvention(Assembly.GetExecutingAssembly());
        }
    }
}
