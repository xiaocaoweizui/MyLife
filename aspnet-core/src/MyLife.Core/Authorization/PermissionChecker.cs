using Abp.Authorization;
using MyLife.Authorization.Roles;
using MyLife.Authorization.Users;

namespace MyLife.Authorization
{
    public class PermissionChecker : PermissionChecker<Role, User>
    {
        public PermissionChecker(UserManager userManager)
            : base(userManager)
        {
        }
    }
}
