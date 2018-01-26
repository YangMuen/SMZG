using System.Threading.Tasks;
using Abp.Application.Services;
using SMZG.Configuration.Dto;

namespace SMZG.Configuration
{
    public interface IConfigurationAppService: IApplicationService
    {
        Task ChangeUiTheme(ChangeUiThemeInput input);
    }
}