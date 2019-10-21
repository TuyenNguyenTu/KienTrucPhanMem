using System.Linq;
using Project.KienTrucPhanMem.EntityFramework;
using Project.KienTrucPhanMem.MultiTenancy;

namespace Project.KienTrucPhanMem.Migrations.SeedData
{
    public class DefaultTenantCreator
    {
        private readonly KienTrucPhanMemDbContext _context;

        public DefaultTenantCreator(KienTrucPhanMemDbContext context)
        {
            _context = context;
        }

        public void Create()
        {
            CreateUserAndRoles();
        }

        private void CreateUserAndRoles()
        {
            //Default tenant

            var defaultTenant = _context.Tenants.FirstOrDefault(t => t.TenancyName == Tenant.DefaultTenantName);
            if (defaultTenant == null)
            {
                _context.Tenants.Add(new Tenant {TenancyName = Tenant.DefaultTenantName, Name = Tenant.DefaultTenantName});
                _context.SaveChanges();
            }
        }
    }
}
