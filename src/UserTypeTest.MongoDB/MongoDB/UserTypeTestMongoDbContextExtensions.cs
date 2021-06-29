using System;
using Volo.Abp;
using Volo.Abp.MongoDB;

namespace UserTypeTest.MongoDB
{
    public static class UserTypeTestMongoDbContextExtensions
    {
        public static void ConfigureUserTypeTest(
            this IMongoModelBuilder builder,
            Action<AbpMongoModelBuilderConfigurationOptions> optionsAction = null)
        {
            Check.NotNull(builder, nameof(builder));

            var options = new UserTypeTestMongoModelBuilderConfigurationOptions(
                UserTypeTestDbProperties.DbTablePrefix
            );

            optionsAction?.Invoke(options);
        }
    }
}