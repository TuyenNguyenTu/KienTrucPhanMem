using System.Threading.Tasks;
using Abp.Application.Services;
using Project.KienTrucPhanMem.Sessions.Dto;

namespace Project.KienTrucPhanMem.Sessions
{
    public interface ISessionAppService : IApplicationService
    {
        Task<GetCurrentLoginInformationsOutput> GetCurrentLoginInformations();
    }
}
