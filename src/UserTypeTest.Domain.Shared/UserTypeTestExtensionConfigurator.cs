using System;
using System.Collections.Generic;
using System.Text;
using Volo.Abp.ObjectExtending;
using Volo.Abp.Threading;
using System.ComponentModel.DataAnnotations;
using UserTypeTest.Users;
using Volo.Abp.Localization;

namespace UserTypeTest
{
    public static class UserTypeTestExtensionConfigurator
    {
        private static readonly OneTimeRunner OneTimeRunner = new OneTimeRunner();

        public static void Configure()
        {
            OneTimeRunner.Run(() =>
            {
                ConfigureExistingProperties();
                ConfigureExtraProperties();
            });
        }

        private static void ConfigureExistingProperties()
        {
            /* You can change max lengths for properties of the
             * entities defined in the modules used by your application.
             *
             * Example: Change user and role name max lengths

               IdentityUserConsts.MaxNameLength = 99;
               IdentityRoleConsts.MaxNameLength = 99;

             * Notice: It is not suggested to change property lengths
             * unless you really need it. Go with the standard values wherever possible.
             *
             * If you are using EF Core, you will need to run the add-migration command after your changes.
             */
        }

        public static void ConfigureExtraProperties()
        {
            ObjectExtensionManager.Instance.Modules()
                .ConfigureIdentity(identity =>
                {
                    identity.ConfigureUser(user =>
                    {
                        user.AddOrUpdateProperty<UserType>(
                            "Type",
                            property =>
                            {
                                //validation rules
                                property.Attributes.Add(new RequiredAttribute());

                                //...other configurations for this property
                                property.DefaultValue = UserType.Guest;
                                property.DisplayName = new FixedLocalizableString("用户类型");
                            }
                        );
                    });
                });
        }
    }
}
