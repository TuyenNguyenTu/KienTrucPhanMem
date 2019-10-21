using Abp.AutoMapper;
using Project.KienTrucPhanMem.Sessions.Dto;

namespace Project.KienTrucPhanMem.Web.Models.Account
{
    [AutoMapFrom(typeof(GetCurrentLoginInformationsOutput))]
    public class TenantChangeViewModel
    {
        public TenantLoginInfoDto Tenant { get; set; }
    }
}