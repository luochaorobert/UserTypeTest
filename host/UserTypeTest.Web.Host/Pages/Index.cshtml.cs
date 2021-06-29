using System.Threading.Tasks;
using Microsoft.AspNetCore.Authentication;

namespace UserTypeTest.Pages
{
    public class IndexModel : UserTypeTestPageModel
    {
        public void OnGet()
        {
            
        }

        public async Task OnPostLoginAsync()
        {
            await HttpContext.ChallengeAsync("oidc");
        }
    }
}