using System.Data.Common;
using System.Data.Entity;
using Abp.Zero.EntityFramework;
using Project.KienTrucPhanMem.Authorization.Roles;
using Project.KienTrucPhanMem.Authorization.Users;
using Project.KienTrucPhanMem.MultiTenancy;

namespace Project.KienTrucPhanMem.EntityFramework
{
    public class KienTrucPhanMemDbContext : AbpZeroDbContext<Tenant, Role, User>
    {
        //TODO: Define an IDbSet for your Entities...

        /* NOTE: 
         *   Setting "Default" to base class helps us when working migration commands on Package Manager Console.
         *   But it may cause problems when working Migrate.exe of EF. If you will apply migrations on command line, do not
         *   pass connection string name to base classes. ABP works either way.
         */
        public KienTrucPhanMemDbContext()
            : base("Default")
        {

        }

        /* NOTE:
         *   This constructor is used by ABP to pass connection string defined in KienTrucPhanMemDataModule.PreInitialize.
         *   Notice that, actually you will not directly create an instance of KienTrucPhanMemDbContext since ABP automatically handles it.
         */
        public KienTrucPhanMemDbContext(string nameOrConnectionString)
            : base(nameOrConnectionString)
        {

        }

        //This constructor is used in tests
        public KienTrucPhanMemDbContext(DbConnection existingConnection)
         : base(existingConnection, false)
        {

        }

        public KienTrucPhanMemDbContext(DbConnection existingConnection, bool contextOwnsConnection)
         : base(existingConnection, contextOwnsConnection)
        {

        }

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);

        }
    }
}
