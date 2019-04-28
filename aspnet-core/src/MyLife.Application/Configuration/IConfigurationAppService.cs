using System.Threading.Tasks;
using MyLife.Configuration.Dto;

namespace MyLife.Configuration
{
    public interface IConfigurationAppService
    {
        Task ChangeUiTheme(ChangeUiThemeInput input);
    }
}
