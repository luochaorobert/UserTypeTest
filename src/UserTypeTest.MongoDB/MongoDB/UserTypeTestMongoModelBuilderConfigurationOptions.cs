using JetBrains.Annotations;
using Volo.Abp.MongoDB;

namespace UserTypeTest.MongoDB
{
    public class UserTypeTestMongoModelBuilderConfigurationOptions : AbpMongoModelBuilderConfigurationOptions
    {
        public UserTypeTestMongoModelBuilderConfigurationOptions(
            [NotNull] string collectionPrefix = "")
            : base(collectionPrefix)
        {
        }
    }
}