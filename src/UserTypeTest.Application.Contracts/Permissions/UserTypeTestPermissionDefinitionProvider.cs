using UserTypeTest.Localization;
using Volo.Abp.Authorization.Permissions;
using Volo.Abp.Localization;

namespace UserTypeTest.Permissions
{
    public class UserTypeTestPermissionDefinitionProvider : PermissionDefinitionProvider
    {
        public override void Define(IPermissionDefinitionContext context)
        {
            var myGroup = context.AddGroup(UserTypeTestPermissions.GroupName, L("Permission:UserTypeTest"));
        }

        private static LocalizableString L(string name)
        {
            return LocalizableString.Create<UserTypeTestResource>(name);
        }
    }
}