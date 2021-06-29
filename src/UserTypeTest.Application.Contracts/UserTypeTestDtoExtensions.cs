using System;
using System.Collections.Generic;
using System.Text;
using Volo.Abp.ObjectExtending;
using Volo.Abp.Threading;
using Volo.Abp.Identity;
using UserTypeTest.Users;

namespace UserTypeTest
{
    public static class UserTypeTestDtoExtensions
    {
        private static readonly OneTimeRunner OneTimeRunner = new OneTimeRunner();

        public static void Configure()
        {
            OneTimeRunner.Run(() =>
            {
                ObjectExtensionManager.Instance
                    .AddOrUpdateProperty<UserType>(
                        new[]
                        {
                        typeof(IdentityUserDto),
                        typeof(IdentityUserCreateOrUpdateDtoBase),
                        typeof(ProfileDto),
                        typeof(UpdateProfileDto)
                        },
                        "Type",
                        options =>
                        {
                            options.DefaultValue = UserType.Guest;
                        }
                    );
            });
        }
    }
}
