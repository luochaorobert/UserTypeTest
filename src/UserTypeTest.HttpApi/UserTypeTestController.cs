using UserTypeTest.Localization;
using Volo.Abp.AspNetCore.Mvc;

namespace UserTypeTest
{
    public abstract class UserTypeTestController : AbpController
    {
        protected UserTypeTestController()
        {
            LocalizationResource = typeof(UserTypeTestResource);
        }
    }
}
