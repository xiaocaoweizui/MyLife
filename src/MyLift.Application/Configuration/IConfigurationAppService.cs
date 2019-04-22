using System.Threading.Tasks;
using Abp.Application.Services;
using MyLift.Configuration.Dto;

namespace MyLift.Configuration
{
    public interface IConfigurationAppService: IApplicationService
    {
        Task ChangeUiTheme(ChangeUiThemeInput input);
    }
}