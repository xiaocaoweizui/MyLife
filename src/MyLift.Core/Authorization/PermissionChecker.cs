using Abp.Authorization;
using MyLift.Authorization.Roles;
using MyLift.Authorization.Users;

namespace MyLift.Authorization
{
    public class PermissionChecker : PermissionChecker<Role, User>
    {
        public PermissionChecker(UserManager userManager)
            : base(userManager)
        {

        }
    }
}
