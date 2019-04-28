using Abp.Application.Services;
using Abp.Application.Services.Dto;
using MyLife.MultiTenancy.Dto;

namespace MyLife.MultiTenancy
{
    public interface ITenantAppService : IAsyncCrudAppService<TenantDto, int, PagedTenantResultRequestDto, CreateTenantDto, TenantDto>
    {
    }
}

