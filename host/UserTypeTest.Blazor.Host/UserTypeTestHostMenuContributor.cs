using System.Threading.Tasks;
using UserTypeTest.Localization;
using Volo.Abp.UI.Navigation;

namespace UserTypeTest.Blazor.Host
{
    public class UserTypeTestHostMenuContributor : IMenuContributor
    {
        public Task ConfigureMenuAsync(MenuConfigurationContext context)
        {
            if(context.Menu.DisplayName != StandardMenus.Main)
            {
                return Task.CompletedTask;
            }

            var l = context.GetLocalizer<UserTypeTestResource>();

            context.Menu.Items.Insert(
                0,
                new ApplicationMenuItem(
                    "UserTypeTest.Home",
                    l["Menu:Home"],
                    "/",
                    icon: "fas fa-home"
                )
            );

            return Task.CompletedTask;
        }
    }
}
