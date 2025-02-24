using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using OpenQA.Selenium;
using SwagLabProject.Selenium.Pages;

namespace SwagLabProject.Selenium.Actions
{
    public class LoginActions
    {
        private readonly LoginPage _loginPage;

        public LoginActions(IWebDriver driver) => _loginPage = new LoginPage(driver);

        public void Login(string username, string password)
        {
            _loginPage.EnterUsername(username);
            _loginPage.EnterPassword(password);
            _loginPage.ClickLogin();
        }
    }
}
