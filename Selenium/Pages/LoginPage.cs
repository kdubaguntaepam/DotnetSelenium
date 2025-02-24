using OpenQA.Selenium;

namespace SwagLabProject.Selenium.Pages
{
    public class LoginPage
    {
        private readonly IWebDriver _driver;
        private readonly By _usernameField = By.Id("user-name");
        private readonly By _passwordField = By.Id("password");
        private readonly By _loginButton = By.Id("login-button");

        public LoginPage(IWebDriver driver) => _driver = driver;

        public void EnterUsername(string username) => _driver.FindElement(_usernameField).SendKeys(username);
        public void EnterPassword(string password) => _driver.FindElement(_passwordField).SendKeys(password);
        public void ClickLogin() => _driver.FindElement(_loginButton).Click();

        public bool IsOnLoginPage() => _driver.Url.Contains("saucedemo");
    }
}
