using Localization.Resources.AbpUi;
using UserTypeTest.Localization;
using Volo.Abp.AspNetCore.Mvc;
using Volo.Abp.Localization;
using Volo.Abp.Modularity;
using Microsoft.Extensions.DependencyInjection;

namespace UserTypeTest
{
    [DependsOn(
        typeof(UserTypeTestApplicationContractsModule),
        typeof(AbpAspNetCoreMvcModule))]
    public class UserTypeTestHttpApiModule : AbpModule
    {
        public override void PreConfigureServices(ServiceConfigurationContext context)
        {
            PreConfigure<IMvcBuilder>(mvcBuilder =>
            {
                mvcBuilder.AddApplicationPartIfNotExists(typeof(UserTypeTestHttpApiModule).Assembly);
            });
        }

        public override void ConfigureServices(ServiceConfigurationContext context)
        {
            Configure<AbpLocalizationOptions>(options =>
            {
                options.Resources
                    .Get<UserTypeTestResource>()
                    .AddBaseTypes(typeof(AbpUiResource));
            });
        }
    }
}
