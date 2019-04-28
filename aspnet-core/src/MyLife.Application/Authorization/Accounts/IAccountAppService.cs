using System.Threading.Tasks;
using Abp.Application.Services;
using MyLife.Authorization.Accounts.Dto;

namespace MyLife.Authorization.Accounts
{
    public interface IAccountAppService : IApplicationService
    {
        Task<IsTenantAvailableOutput> IsTenantAvailable(IsTenantAvailableInput input);

        Task<RegisterOutput> Register(RegisterInput input);
    }
}
