using System.Threading.Tasks;
using Abp.Application.Services;
using MyLift.Sessions.Dto;

namespace MyLift.Sessions
{
    public interface ISessionAppService : IApplicationService
    {
        Task<GetCurrentLoginInformationsOutput> GetCurrentLoginInformations();
    }
}
