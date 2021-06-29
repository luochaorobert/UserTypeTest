using Volo.Abp.Data;
using Volo.Abp.MongoDB;

namespace UserTypeTest.MongoDB
{
    [ConnectionStringName(UserTypeTestDbProperties.ConnectionStringName)]
    public interface IUserTypeTestMongoDbContext : IAbpMongoDbContext
    {
        /* Define mongo collections here. Example:
         * IMongoCollection<Question> Questions { get; }
         */
    }
}
