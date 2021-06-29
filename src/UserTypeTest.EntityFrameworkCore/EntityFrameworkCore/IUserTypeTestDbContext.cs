using Volo.Abp.Data;
using Volo.Abp.EntityFrameworkCore;

namespace UserTypeTest.EntityFrameworkCore
{
    [ConnectionStringName(UserTypeTestDbProperties.ConnectionStringName)]
    public interface IUserTypeTestDbContext : IEfCoreDbContext
    {
        /* Add DbSet for each Aggregate Root here. Example:
         * DbSet<Question> Questions { get; }
         */
    }
}