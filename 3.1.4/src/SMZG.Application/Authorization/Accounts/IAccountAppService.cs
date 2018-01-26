using System.Threading.Tasks;
using Abp.Application.Services;
using SMZG.Authorization.Accounts.Dto;

namespace SMZG.Authorization.Accounts
{
    public interface IAccountAppService : IApplicationService
    {
        Task<IsTenantAvailableOutput> IsTenantAvailable(IsTenantAvailableInput input);

        Task<RegisterOutput> Register(RegisterInput input);
    }
}
