using System.Threading.Tasks;
using Volo.Abp.UI.Navigation;

namespace UserTypeTest.Web.Menus
{
    public class UserTypeTestMenuContributor : IMenuContributor
    {
        public async Task ConfigureMenuAsync(MenuConfigurationContext context)
        {
            if (context.Menu.Name == StandardMenus.Main)
            {
                await ConfigureMainMenuAsync(context);
            }
        }

        private Task ConfigureMainMenuAsync(MenuConfigurationContext context)
        {
            //Add main menu items.
            context.Menu.AddItem(new ApplicationMenuItem(UserTypeTestMenus.Prefix, displayName: "UserTypeTest", "~/UserTypeTest", icon: "fa fa-globe"));

            return Task.CompletedTask;
        }
    }
}