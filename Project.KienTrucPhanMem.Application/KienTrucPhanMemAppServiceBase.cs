﻿using System;
using System.Threading.Tasks;
using Abp.Application.Services;
using Abp.IdentityFramework;
using Abp.Runtime.Session;
using Project.KienTrucPhanMem.Authorization.Users;
using Project.KienTrucPhanMem.MultiTenancy;
using Project.KienTrucPhanMem.Users;
using Microsoft.AspNet.Identity;

namespace Project.KienTrucPhanMem
{
    /// <summary>
    /// Derive your application services from this class.
    /// </summary>
    public abstract class KienTrucPhanMemAppServiceBase : ApplicationService
    {
        public TenantManager TenantManager { get; set; }

        public UserManager UserManager { get; set; }

        protected KienTrucPhanMemAppServiceBase()
        {
            LocalizationSourceName = KienTrucPhanMemConsts.LocalizationSourceName;
        }

        protected virtual async Task<User> GetCurrentUserAsync()
        {
            var user = await UserManager.FindByIdAsync(AbpSession.GetUserId());
            if (user == null)
            {
                throw new ApplicationException("There is no current user!");
            }

            return user;
        }

        protected virtual Task<Tenant> GetCurrentTenantAsync()
        {
            return TenantManager.GetByIdAsync(AbpSession.GetTenantId());
        }

        protected virtual void CheckErrors(IdentityResult identityResult)
        {
            identityResult.CheckErrors(LocalizationManager);
        }
    }
}