using NUnit.Framework;
using SwagLabProject.PlaywrightCode.Actions;
using SwagLabProject.PlaywrightCode.Drivers;
using System.Threading.Tasks;

namespace SwagLabProject.PlaywrightCode.TestSuite
{
    public class LoginTests : WebDriverSetup
    {
        [Test]
        public async Task Login_WithValidCredentials_ShouldBeSuccessful()
        {
            var loginActions = new LoginActions(Page);
            await loginActions.LoginAsync("standard_user", "secret_sauce");

            Assert.That(Page.Url.Contains("inventory"), "Login failed!");
        }
    }
}
