using Abp.Application.Navigation;
using Abp.Localization;
using Project.KienTrucPhanMem.Authorization;

namespace Project.KienTrucPhanMem.Web
{
    /// <summary>
    /// This class defines menus for the application.
    /// It uses ABP's menu system.
    /// When you add menu items here, they are automatically appear in angular application.
    /// See .cshtml and .js files under App/Main/views/layout/header to know how to render menu.
    /// </summary>
    public class KienTrucPhanMemNavigationProvider : NavigationProvider
    {
        public override void SetNavigation(INavigationProviderContext context)
        {
            context.Manager.MainMenu
                .AddItem(
                    new MenuItemDefinition(
                        "Home",
                        new LocalizableString("HomePage", KienTrucPhanMemConsts.LocalizationSourceName),
                        url: "#/",
                        icon: "fa fa-home",
                        requiresAuthentication: true
                        )
                )
                .AddItem(
                    new MenuItemDefinition(
                        "Tenants",
                        L("Tenants"),
                        url: "#tenants",
                        icon: "fa fa-globe",
                        requiredPermissionName: PermissionNames.Pages_Users
                        )
                )
                .AddItem(
                    new MenuItemDefinition(
                        "Users",
                        L("Users"),
                        url: "#users",
                        icon: "fa fa-users",
                        requiredPermissionName: PermissionNames.Pages_Users
                        )
                )
                .AddItem(
                    new MenuItemDefinition(
                        "Roles",
                        L("Roles"),
                        url: "#users",
                        icon: "fa fa-tag",
                        requiredPermissionName: PermissionNames.Pages_Users
                    )
                )
                ///Menu tiếp nhân
                .AddItem(
                    new MenuItemDefinition(
                        "DangKyKham",
                        L("DangKyKham"),
                        url: "#dangkykham",
                        icon: "fa fa-tag",
                        requiredPermissionName: PermissionNames.Pages_TiepNhans
                    ).AddItem(
                    new MenuItemDefinition(
                        "QLBenhNhan",
                        L("QLBenhNhan"),
                        url: "#users",
                        icon: "fa fa-tag",
                        requiredPermissionName: PermissionNames.Pages_TiepNhans
                    )
                    .AddItem(
                    new MenuItemDefinition(
                        "QLPhieuDangKyKham",
                        L("QLPhieuDangKyKham"),
                        url: "#users",
                        icon: "fa fa-tag",
                        requiredPermissionName: PermissionNames.Pages_TiepNhans
                    )
                    .AddItem(
                    new MenuItemDefinition(
                        "QLPhieuSuDungDichVu",
                        L("QLPhieuSuDungDichVu"),
                        url: "#users",
                        icon: "fa fa-tag",
                        requiredPermissionName: PermissionNames.Pages_TiepNhans
                    ))))
                )
                .AddItem(
                    new MenuItemDefinition(
                        "About",
                        new LocalizableString("About", KienTrucPhanMemConsts.LocalizationSourceName),
                        url: "#/about",
                        icon: "fa fa-info"
                        )
                );
        }

        private static ILocalizableString L(string name)
        {
            return new LocalizableString(name, KienTrucPhanMemConsts.LocalizationSourceName);
        }
    }
}
