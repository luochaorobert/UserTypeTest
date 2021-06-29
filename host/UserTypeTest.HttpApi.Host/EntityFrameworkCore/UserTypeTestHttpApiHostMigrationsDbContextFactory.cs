using System.IO;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Design;
using Microsoft.Extensions.Configuration;

namespace UserTypeTest.EntityFrameworkCore
{
    public class UserTypeTestHttpApiHostMigrationsDbContextFactory : IDesignTimeDbContextFactory<UserTypeTestHttpApiHostMigrationsDbContext>
    {
        public UserTypeTestHttpApiHostMigrationsDbContext CreateDbContext(string[] args)
        {
            var configuration = BuildConfiguration();

            var builder = new DbContextOptionsBuilder<UserTypeTestHttpApiHostMigrationsDbContext>()
                .UseSqlServer(configuration.GetConnectionString("UserTypeTest"));

            return new UserTypeTestHttpApiHostMigrationsDbContext(builder.Options);
        }

        private static IConfigurationRoot BuildConfiguration()
        {
            var builder = new ConfigurationBuilder()
                .SetBasePath(Directory.GetCurrentDirectory())
                .AddJsonFile("appsettings.json", optional: false);

            return builder.Build();
        }
    }
}
