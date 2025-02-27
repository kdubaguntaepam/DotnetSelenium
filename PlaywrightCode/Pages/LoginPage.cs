using System.Threading.Tasks;
using Microsoft.Playwright;

namespace SwagLabProject.PlaywrightCode.Pages
{
    public class LoginPage
    {
        private readonly IPage _page;

        public LoginPage(IPage page) => _page = page;

        public async Task EnterUsernameAsync(string username) => await _page.FillAsync("#user-name", username);
        public async Task EnterPasswordAsync(string password) => await _page.FillAsync("#password", password);
        public async Task ClickLoginAsync() => await _page.ClickAsync("#login-button");

        public bool IsOnLoginPage() => _page.Url.Contains("saucedemo");
    }
}
