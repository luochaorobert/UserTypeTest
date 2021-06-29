using Volo.Abp.Modularity;

namespace UserTypeTest
{
    [DependsOn(
        typeof(UserTypeTestApplicationModule),
        typeof(UserTypeTestDomainTestModule)
        )]
    public class UserTypeTestApplicationTestModule : AbpModule
    {

    }
}
