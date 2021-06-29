using Microsoft.Extensions.DependencyInjection;
using UserTypeTest.Blazor.Menus;
using Volo.Abp.AspNetCore.Components.Web.Theming;
using Volo.Abp.AspNetCore.Components.Web.Theming.Routing;
using Volo.Abp.AutoMapper;
using Volo.Abp.Modularity;
using Volo.Abp.UI.Navigation;

namespace UserTypeTest.Blazor
{
    [DependsOn(
        typeof(UserTypeTestApplicationContractsModule),
        typeof(AbpAspNetCoreComponentsWebThemingModule),
        typeof(AbpAutoMapperModule)
        )]
    public class UserTypeTestBlazorModule : AbpModule
    {
        public override void ConfigureServices(ServiceConfigurationContext context)
        {
            context.Services.AddAutoMapperObjectMapper<UserTypeTestBlazorModule>();

            Configure<AbpAutoMapperOptions>(options =>
            {
                options.AddProfile<UserTypeTestBlazorAutoMapperProfile>(validate: true);
            });

            Configure<AbpNavigationOptions>(options =>
            {
                options.MenuContributors.Add(new UserTypeTestMenuContributor());
            });

            Configure<AbpRouterOptions>(options =>
            {
                options.AdditionalAssemblies.Add(typeof(UserTypeTestBlazorModule).Assembly);
            });
        }
    }
}