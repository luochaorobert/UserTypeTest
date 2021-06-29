using System;
using System.Collections.Generic;
using System.Text;
using Volo.Abp.Identity;
using Volo.Abp.ObjectExtending;
using Volo.Abp.Threading;
using Microsoft.EntityFrameworkCore;
using UserTypeTest.Users;

namespace UserTypeTest.EntityFrameworkCore
{
    public static class UserTypeTestEfCoreEntityExtensionMappings
    {
        private static readonly OneTimeRunner OneTimeRunner = new OneTimeRunner();

        public static void Configure()
        {
            OneTimeRunner.Run(() =>
            {
                ObjectExtensionManager.Instance
                    .MapEfCoreProperty<IdentityUser, UserType>(
                        "Type",
                        (entityBuilder, propertyBuilder) =>
                        {
                            propertyBuilder.HasDefaultValue(UserType.Guest);
                        }
                    );
            });
        }
    }
}
