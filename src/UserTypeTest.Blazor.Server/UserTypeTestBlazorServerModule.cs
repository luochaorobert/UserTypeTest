using Volo.Abp.AspNetCore.Components.Server.Theming;
using Volo.Abp.Modularity;

namespace UserTypeTest.Blazor.Server
{
    [DependsOn(
        typeof(AbpAspNetCoreComponentsServerThemingModule),
        typeof(UserTypeTestBlazorModule)
        )]
    public class UserTypeTestBlazorServerModule : AbpModule
    {
        
    }
}