using Abp.MultiTenancy;
using Project.KienTrucPhanMem.Authorization.Users;

namespace Project.KienTrucPhanMem.MultiTenancy
{
    public class Tenant : AbpTenant<User>
    {
        public Tenant()
        {
            
        }

        public Tenant(string tenancyName, string name)
            : base(tenancyName, name)
        {
        }
    }
}