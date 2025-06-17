using System.Threading.Tasks;
using NUnit.Framework;
using SwagLabProject.PlaywrightCode.Actions;
using SwagLabProject.PlaywrightCode.Drivers;

namespace SwagLabProject.PlaywrightCode.TestSuite
{
    public class LoginTests : WebDriverSetup
    {
        [Test]
        public async Task Login_WithValidCredentials_ShouldBeSuccessfulAsync()
        {
            var loginActions = new LoginActions(_page);
            await loginActions.LoginAsync("standard_user", "secret_sauce");

            Assert.That(_page.Url.Contains("inventory"), "Login failed!");
        }
    }
}
