using System.Threading.Tasks;
using Abp.Application.Services;
using MyLife.Sessions.Dto;

namespace MyLife.Sessions
{
    public interface ISessionAppService : IApplicationService
    {
        Task<GetCurrentLoginInformationsOutput> GetCurrentLoginInformations();
    }
}
