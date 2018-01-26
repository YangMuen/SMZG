using System.Threading.Tasks;
using Abp.Authorization;
using Abp.Runtime.Session;
using SMZG.Configuration.Dto;

namespace SMZG.Configuration
{
    [AbpAuthorize]
    public class ConfigurationAppService : SMZGAppServiceBase, IConfigurationAppService
    {
        public async Task ChangeUiTheme(ChangeUiThemeInput input)
        {
            await SettingManager.ChangeSettingForUserAsync(AbpSession.ToUserIdentifier(), AppSettingNames.UiTheme, input.Theme);
        }
    }
}
