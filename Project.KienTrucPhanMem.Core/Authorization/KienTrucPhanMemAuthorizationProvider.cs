using Abp.Authorization;
using Abp.Localization;
using Abp.MultiTenancy;

namespace Project.KienTrucPhanMem.Authorization
{
    public class KienTrucPhanMemAuthorizationProvider : AuthorizationProvider
    {
        public override void SetPermissions(IPermissionDefinitionContext context)
        {
            context.CreatePermission(PermissionNames.Pages_Administrators, L("Administrators"));
            context.CreatePermission(PermissionNames.Pages_Bacsis, L("Bac_si"));
            context.CreatePermission(PermissionNames.Pages_ThuNgans, L("Thu_Ngan"));
            context.CreatePermission(PermissionNames.Pages_TiepNhans, L("Tiep_Nhan"));
            context.CreatePermission(PermissionNames.Pages_QuanTris, L("Quan_Tri"));
            context.CreatePermission(PermissionNames.Pages_Users, L("Users"));
            context.CreatePermission(PermissionNames.Pages_Roles, L("Roles"));
            context.CreatePermission(PermissionNames.Pages_Tenants, L("Tenants"), multiTenancySides: MultiTenancySides.Host);
        }

        private static ILocalizableString L(string name)
        {
            return new LocalizableString(name, KienTrucPhanMemConsts.LocalizationSourceName);
        }
    }
}
