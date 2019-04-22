using System.Data.Entity;
using System.Reflection;
using Abp.Modules;
using MyLift.EntityFramework;

namespace MyLift.Migrator
{
    [DependsOn(typeof(MyLiftDataModule))]
    public class MyLiftMigratorModule : AbpModule
    {
        public override void PreInitialize()
        {
            Database.SetInitializer<MyLiftDbContext>(null);

            Configuration.BackgroundJobs.IsJobExecutionEnabled = false;
        }

        public override void Initialize()
        {
            IocManager.RegisterAssemblyByConvention(Assembly.GetExecutingAssembly());
        }
    }
}