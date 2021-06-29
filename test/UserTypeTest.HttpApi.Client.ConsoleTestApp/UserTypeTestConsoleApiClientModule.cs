using Volo.Abp.Http.Client.IdentityModel;
using Volo.Abp.Modularity;

namespace UserTypeTest
{
    [DependsOn(
        typeof(UserTypeTestHttpApiClientModule),
        typeof(AbpHttpClientIdentityModelModule)
        )]
    public class UserTypeTestConsoleApiClientModule : AbpModule
    {
        
    }
}
