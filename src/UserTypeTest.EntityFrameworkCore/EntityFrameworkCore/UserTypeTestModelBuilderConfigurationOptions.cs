using JetBrains.Annotations;
using Volo.Abp.EntityFrameworkCore.Modeling;

namespace UserTypeTest.EntityFrameworkCore
{
    public class UserTypeTestModelBuilderConfigurationOptions : AbpModelBuilderConfigurationOptions
    {
        public UserTypeTestModelBuilderConfigurationOptions(
            [NotNull] string tablePrefix = "",
            [CanBeNull] string schema = null)
            : base(
                tablePrefix,
                schema)
        {

        }
    }
}