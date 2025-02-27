using System;
using System.Threading.Tasks;
using SwagLabProject.PlaywrightCode.Pages;
using Microsoft.Playwright;

namespace SwagLabProject.PlaywrightCode.Actions
{
    public class LoginActions
    {
        private readonly LoginPage _loginPage;

        public LoginActions(IPage page) => _loginPage = new LoginPage(page);

        public async Task LoginAsync(string username, string password)
        {
            await _loginPage.EnterUsernameAsync(username);
            await _loginPage.EnterPasswordAsync(password);
            await _loginPage.ClickLoginAsync();
        }
    }
}