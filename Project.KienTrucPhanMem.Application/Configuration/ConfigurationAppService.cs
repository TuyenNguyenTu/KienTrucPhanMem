using System.Threading.Tasks;
using Abp.Authorization;
using Abp.Runtime.Session;
using Project.KienTrucPhanMem.Configuration.Dto;

namespace Project.KienTrucPhanMem.Configuration
{
    [AbpAuthorize]
    public class ConfigurationAppService : KienTrucPhanMemAppServiceBase, IConfigurationAppService
    {
        public async Task ChangeUiTheme(ChangeUiThemeInput input)
        {
            await SettingManager.ChangeSettingForUserAsync(AbpSession.ToUserIdentifier(), AppSettingNames.UiTheme, input.Theme);
        }
    }
}
