using Abp.Application.Services;
using Abp.Application.Services.Dto;
using MyLift.MultiTenancy.Dto;

namespace MyLift.MultiTenancy
{
    public interface ITenantAppService : IAsyncCrudAppService<TenantDto, int, PagedResultRequestDto, CreateTenantDto, TenantDto>
    {
    }
}
