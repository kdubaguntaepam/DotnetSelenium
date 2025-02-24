using System.Threading.Tasks;\nusing NUnit.Framework;\nusing SwagLabProject.PlaywrightCode.Actions;\nusing SwagLabProject.PlaywrightCode.Drivers;\n\nnamespace SwagLabProject.PlaywrightCode.TestSuite\n{\n    public class LoginTests : WebDriverSetup\n    {\n        [Test]
        public async Task Login_WithValidCredentials_ShouldBeSuccessfulAsync()
        {
            var loginActions = new LoginActions(page);
            await loginActions.LoginAsync("standard_user", "secret_sauce");

            var loginPage = new SwagLabProject.PlaywrightCode.Pages.LoginPage(page);
            Assert.That((await page.UrlAsync()).Contains("inventory"), "Login failed!");
        }\n