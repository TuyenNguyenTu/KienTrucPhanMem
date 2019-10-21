using Abp.Application.Services;
using Abp.Application.Services.Dto;
using Project.KienTrucPhanMem.MultiTenancy.Dto;

namespace Project.KienTrucPhanMem.MultiTenancy
{
    public interface ITenantAppService : IAsyncCrudAppService<TenantDto, int, PagedResultRequestDto, CreateTenantDto, TenantDto>
    {
    }
}
