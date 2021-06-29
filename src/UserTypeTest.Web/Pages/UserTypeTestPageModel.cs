using UserTypeTest.Localization;
using Volo.Abp.AspNetCore.Mvc.UI.RazorPages;

namespace UserTypeTest.Web.Pages
{
    /* Inherit your PageModel classes from this class.
     */
    public abstract class UserTypeTestPageModel : AbpPageModel
    {
        protected UserTypeTestPageModel()
        {
            LocalizationResourceType = typeof(UserTypeTestResource);
            ObjectMapperContext = typeof(UserTypeTestWebModule);
        }
    }
}