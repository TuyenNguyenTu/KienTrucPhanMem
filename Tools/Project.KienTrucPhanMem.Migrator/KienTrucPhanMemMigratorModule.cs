using System.Data.Entity;
using System.Reflection;
using Abp.Modules;
using Project.KienTrucPhanMem.EntityFramework;

namespace Project.KienTrucPhanMem.Migrator
{
    [DependsOn(typeof(KienTrucPhanMemDataModule))]
    public class KienTrucPhanMemMigratorModule : AbpModule
    {
        public override void PreInitialize()
        {
            Database.SetInitializer<KienTrucPhanMemDbContext>(null);

            Configuration.BackgroundJobs.IsJobExecutionEnabled = false;
        }

        public override void Initialize()
        {
            IocManager.RegisterAssemblyByConvention(Assembly.GetExecutingAssembly());
        }
    }
}