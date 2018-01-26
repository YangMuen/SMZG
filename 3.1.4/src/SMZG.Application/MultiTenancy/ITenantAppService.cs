using Abp.Application.Services;
using Abp.Application.Services.Dto;
using SMZG.MultiTenancy.Dto;

namespace SMZG.MultiTenancy
{
    public interface ITenantAppService : IAsyncCrudAppService<TenantDto, int, PagedResultRequestDto, CreateTenantDto, TenantDto>
    {
    }
}
