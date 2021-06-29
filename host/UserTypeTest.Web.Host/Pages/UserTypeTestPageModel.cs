using UserTypeTest.Localization;
using Volo.Abp.AspNetCore.Mvc.UI.RazorPages;

namespace UserTypeTest.Pages
{
    public abstract class UserTypeTestPageModel : AbpPageModel
    {
        protected UserTypeTestPageModel()
        {
            LocalizationResourceType = typeof(UserTypeTestResource);
        }
    }
}