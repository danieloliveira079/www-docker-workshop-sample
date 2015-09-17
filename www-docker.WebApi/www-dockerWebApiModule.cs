using System.Reflection;
using Abp.Application.Services;
using Abp.Modules;
using Abp.WebApi;
using Abp.WebApi.Controllers.Dynamic.Builders;

namespace www-docker
{
    [DependsOn(typeof(AbpWebApiModule), typeof(www-dockerApplicationModule))]
    public class www-dockerWebApiModule : AbpModule
    {
        public override void Initialize()
        {
            IocManager.RegisterAssemblyByConvention(Assembly.GetExecutingAssembly());

            DynamicApiControllerBuilder
                .ForAll<IApplicationService>(typeof(www-dockerApplicationModule).Assembly, "app")
                .Build();
        }
    }
}
