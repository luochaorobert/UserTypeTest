using Volo.Abp.Ui.Branding;
using Volo.Abp.DependencyInjection;

namespace UserTypeTest
{
    [Dependency(ReplaceServices = true)]
    public class UserTypeTestBrandingProvider : DefaultBrandingProvider
    {
        public override string AppName => "UserTypeTest";
    }
}
