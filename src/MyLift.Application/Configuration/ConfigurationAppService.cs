using System.Threading.Tasks;
using Abp.Authorization;
using Abp.Runtime.Session;
using MyLift.Configuration.Dto;

namespace MyLift.Configuration
{
    [AbpAuthorize]
    public class ConfigurationAppService : MyLiftAppServiceBase, IConfigurationAppService
    {
        public async Task ChangeUiTheme(ChangeUiThemeInput input)
        {
            await SettingManager.ChangeSettingForUserAsync(AbpSession.ToUserIdentifier(), AppSettingNames.UiTheme, input.Theme);
        }
    }
}
