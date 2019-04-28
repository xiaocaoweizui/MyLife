using System.Threading.Tasks;
using Abp.Authorization;
using Abp.Runtime.Session;
using MyLife.Configuration.Dto;

namespace MyLife.Configuration
{
    [AbpAuthorize]
    public class ConfigurationAppService : MyLifeAppServiceBase, IConfigurationAppService
    {
        public async Task ChangeUiTheme(ChangeUiThemeInput input)
        {
            await SettingManager.ChangeSettingForUserAsync(AbpSession.ToUserIdentifier(), AppSettingNames.UiTheme, input.Theme);
        }
    }
}
