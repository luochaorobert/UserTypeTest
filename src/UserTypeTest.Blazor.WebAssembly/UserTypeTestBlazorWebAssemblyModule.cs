using Volo.Abp.AspNetCore.Components.WebAssembly.Theming;
using Volo.Abp.Modularity;

namespace UserTypeTest.Blazor.WebAssembly
{
    [DependsOn(
        typeof(UserTypeTestBlazorModule),
        typeof(UserTypeTestHttpApiClientModule),
        typeof(AbpAspNetCoreComponentsWebAssemblyThemingModule)
        )]
    public class UserTypeTestBlazorWebAssemblyModule : AbpModule
    {
        
    }
}