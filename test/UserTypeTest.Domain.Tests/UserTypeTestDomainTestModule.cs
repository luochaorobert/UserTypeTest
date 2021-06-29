using UserTypeTest.EntityFrameworkCore;
using Volo.Abp.Modularity;

namespace UserTypeTest
{
    /* Domain tests are configured to use the EF Core provider.
     * You can switch to MongoDB, however your domain tests should be
     * database independent anyway.
     */
    [DependsOn(
        typeof(UserTypeTestEntityFrameworkCoreTestModule)
        )]
    public class UserTypeTestDomainTestModule : AbpModule
    {
        
    }
}
