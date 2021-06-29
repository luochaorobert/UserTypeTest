using Volo.Abp.Domain;
using Volo.Abp.Modularity;

namespace UserTypeTest
{
    [DependsOn(
        typeof(AbpDddDomainModule),
        typeof(UserTypeTestDomainSharedModule)
    )]
    public class UserTypeTestDomainModule : AbpModule
    {

    }
}
