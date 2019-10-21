using System.Threading.Tasks;
using Abp.Application.Services;
using Project.KienTrucPhanMem.Configuration.Dto;

namespace Project.KienTrucPhanMem.Configuration
{
    public interface IConfigurationAppService: IApplicationService
    {
        Task ChangeUiTheme(ChangeUiThemeInput input);
    }
}