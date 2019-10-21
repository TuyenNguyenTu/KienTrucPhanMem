using Abp.Authorization;
using Project.KienTrucPhanMem.Authorization.Roles;
using Project.KienTrucPhanMem.Authorization.Users;

namespace Project.KienTrucPhanMem.Authorization
{
    public class PermissionChecker : PermissionChecker<Role, User>
    {
        public PermissionChecker(UserManager userManager)
            : base(userManager)
        {

        }
    }
}
