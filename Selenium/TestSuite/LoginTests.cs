using NUnit.Framework;
using SwagLabProject.Selenium.Actions;
using SwagLabProject.Selenium.Drivers;

namespace SwagLabProject.Selenium.TestSuite
{
    public class LoginTests : WebDriverSetup
    {
        [Test]
        public void Login_WithValidCredentials_ShouldBeSuccessful()
        {
            var loginActions = new LoginActions(driver);
            loginActions.Login("standard_user", "secret_sauce");

            var loginPage = new SwagLabProject.Selenium.Pages.LoginPage(driver);
            Assert.That(driver.Url.Contains("inventory"), "Login failed!");
        }
    }
}
