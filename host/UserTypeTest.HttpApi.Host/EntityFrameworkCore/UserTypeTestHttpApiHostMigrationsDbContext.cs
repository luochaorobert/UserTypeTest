using Microsoft.EntityFrameworkCore;
using Volo.Abp.EntityFrameworkCore;

namespace UserTypeTest.EntityFrameworkCore
{
    public class UserTypeTestHttpApiHostMigrationsDbContext : AbpDbContext<UserTypeTestHttpApiHostMigrationsDbContext>
    {
        public UserTypeTestHttpApiHostMigrationsDbContext(DbContextOptions<UserTypeTestHttpApiHostMigrationsDbContext> options)
            : base(options)
        {

        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);

            modelBuilder.ConfigureUserTypeTest();
        }
    }
}
