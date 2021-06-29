using Volo.Abp.Data;
using Volo.Abp.MongoDB;

namespace UserTypeTest.MongoDB
{
    [ConnectionStringName(UserTypeTestDbProperties.ConnectionStringName)]
    public class UserTypeTestMongoDbContext : AbpMongoDbContext, IUserTypeTestMongoDbContext
    {
        /* Add mongo collections here. Example:
         * public IMongoCollection<Question> Questions => Collection<Question>();
         */

        protected override void CreateModel(IMongoModelBuilder modelBuilder)
        {
            base.CreateModel(modelBuilder);

            modelBuilder.ConfigureUserTypeTest();
        }
    }
}