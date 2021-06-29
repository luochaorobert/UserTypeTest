using Microsoft.Extensions.DependencyInjection;
using Volo.Abp.Http.Client;
using Volo.Abp.Modularity;

namespace UserTypeTest
{
    [DependsOn(
        typeof(UserTypeTestApplicationContractsModule),
        typeof(AbpHttpClientModule))]
    public class UserTypeTestHttpApiClientModule : AbpModule
    {
        public const string RemoteServiceName = "UserTypeTest";

        public override void ConfigureServices(ServiceConfigurationContext context)
        {
            context.Services.AddHttpClientProxies(
                typeof(UserTypeTestApplicationContractsModule).Assembly,
                RemoteServiceName
            );
        }
    }
}
