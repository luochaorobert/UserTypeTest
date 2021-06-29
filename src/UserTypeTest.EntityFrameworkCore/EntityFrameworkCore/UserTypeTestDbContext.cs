using Microsoft.EntityFrameworkCore;
using Volo.Abp.Data;
using Volo.Abp.EntityFrameworkCore;

namespace UserTypeTest.EntityFrameworkCore
{
    [ConnectionStringName(UserTypeTestDbProperties.ConnectionStringName)]
    public class UserTypeTestDbContext : AbpDbContext<UserTypeTestDbContext>, IUserTypeTestDbContext
    {
        /* Add DbSet for each Aggregate Root here. Example:
         * public DbSet<Question> Questions { get; set; }
         */

        public UserTypeTestDbContext(DbContextOptions<UserTypeTestDbContext> options) 
            : base(options)
        {

        }

        protected override void OnModelCreating(ModelBuilder builder)
        {
            base.OnModelCreating(builder);

            builder.ConfigureUserTypeTest();
        }
    }
}