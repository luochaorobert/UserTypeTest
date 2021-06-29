using UserTypeTest.Localization;
using Volo.Abp.Application.Services;

namespace UserTypeTest
{
    public abstract class UserTypeTestAppService : ApplicationService
    {
        protected UserTypeTestAppService()
        {
            LocalizationResource = typeof(UserTypeTestResource);
            ObjectMapperContext = typeof(UserTypeTestApplicationModule);
        }
    }
}
