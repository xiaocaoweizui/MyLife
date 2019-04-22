using System.Threading.Tasks;
using Abp.Application.Services;
using MyLift.Authorization.Accounts.Dto;

namespace MyLift.Authorization.Accounts
{
    public interface IAccountAppService : IApplicationService
    {
        Task<IsTenantAvailableOutput> IsTenantAvailable(IsTenantAvailableInput input);

        Task<RegisterOutput> Register(RegisterInput input);
    }
}
