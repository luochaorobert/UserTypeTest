using Volo.Abp.Bundling;

namespace UserTypeTest.Blazor.Host
{
    public class UserTypeTestBlazorHostBundleContributor : IBundleContributor
    {
        public void AddScripts(BundleContext context)
        {

        }

        public void AddStyles(BundleContext context)
        {
            context.Add("main.css", true);
        }
    }
}
