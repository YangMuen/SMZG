using Abp.Authorization;
using SMZG.Authorization.Roles;
using SMZG.Authorization.Users;

namespace SMZG.Authorization
{
    public class PermissionChecker : PermissionChecker<Role, User>
    {
        public PermissionChecker(UserManager userManager)
            : base(userManager)
        {

        }
    }
}
