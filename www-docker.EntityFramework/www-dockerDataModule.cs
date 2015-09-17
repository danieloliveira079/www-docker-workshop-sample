using System.Data.Entity;
using System.Reflection;
using Abp.EntityFramework;
using Abp.Modules;
using www-docker.EntityFramework;

namespace www-docker
{
    [DependsOn(typeof(AbpEntityFrameworkModule), typeof(www-dockerCoreModule))]
    public class www-dockerDataModule : AbpModule
    {
        public override void PreInitialize()
        {
            Configuration.DefaultNameOrConnectionString = "Default";
        }

        public override void Initialize()
        {
            IocManager.RegisterAssemblyByConvention(Assembly.GetExecutingAssembly());
            Database.SetInitializer<www-dockerDbContext>(null);
        }
    }
}
