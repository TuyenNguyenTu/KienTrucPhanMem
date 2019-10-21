using System.Data.Entity;
using System.Reflection;
using Abp.Modules;
using Abp.Zero.EntityFramework;
using Project.KienTrucPhanMem.EntityFramework;

namespace Project.KienTrucPhanMem
{
    [DependsOn(typeof(AbpZeroEntityFrameworkModule), typeof(KienTrucPhanMemCoreModule))]
    public class KienTrucPhanMemDataModule : AbpModule
    {
        public override void PreInitialize()
        {
            Database.SetInitializer(new CreateDatabaseIfNotExists<KienTrucPhanMemDbContext>());

            Configuration.DefaultNameOrConnectionString = "Default";
        }

        public override void Initialize()
        {
            IocManager.RegisterAssemblyByConvention(Assembly.GetExecutingAssembly());
        }
    }
}
