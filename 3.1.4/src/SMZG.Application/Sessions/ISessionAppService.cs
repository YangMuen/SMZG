using System.Threading.Tasks;
using Abp.Application.Services;
using SMZG.Sessions.Dto;

namespace SMZG.Sessions
{
    public interface ISessionAppService : IApplicationService
    {
        Task<GetCurrentLoginInformationsOutput> GetCurrentLoginInformations();
    }
}
