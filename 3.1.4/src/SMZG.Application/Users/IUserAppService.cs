using System.Threading.Tasks;
using Abp.Application.Services;
using Abp.Application.Services.Dto;
using SMZG.Roles.Dto;
using SMZG.Users.Dto;

namespace SMZG.Users
{
    public interface IUserAppService : IAsyncCrudAppService<UserDto, long, PagedResultRequestDto, CreateUserDto, UpdateUserDto>
    {
        Task<ListResultDto<RoleDto>> GetRoles();
    }
}