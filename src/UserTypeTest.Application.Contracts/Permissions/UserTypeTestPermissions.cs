using Volo.Abp.Reflection;

namespace UserTypeTest.Permissions
{
    public class UserTypeTestPermissions
    {
        public const string GroupName = "UserTypeTest";

        public static string[] GetAll()
        {
            return ReflectionHelper.GetPublicConstantsRecursively(typeof(UserTypeTestPermissions));
        }
    }
}