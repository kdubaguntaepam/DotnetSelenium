using NUnit.Framework;
using Microsoft.Playwright;
using System.Threading.Tasks;

namespace SwagLabProject.PlaywrightCode.Drivers
{
    public class WebDriverSetup
    {
        protected IPage Page;
        private IBrowser _browser;

        [SetUp]
        public async Task SetupAsync()
        {
            var playwright = await Playwright.CreateAsync();
            _browser = await playwright.Chromium.LaunchAsync(new BrowserTypeLaunchOptions { Headless = false });
            var context = await _browser.NewContextAsync();
            Page = await context.NewPageAsync();
            await Page.GotoAsync("https://www.saucedemo.com/");
        }

        [TearDown]
        public async Task TearDownAsync()
        {
            await _browser.CloseAsync();
        }
    }
}
