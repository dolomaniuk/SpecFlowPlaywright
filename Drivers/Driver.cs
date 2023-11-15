using Microsoft.Playwright;

namespace SpecFlowPlaywright.Drivers
{
    public class Driver : IDisposable
    {
        private readonly Task<IPage> _page;
        private IBrowser? _browser;
        public Driver() => _page = InitializePlaywright();

        public IPage Page => _page.Result;

        private async Task<IPage> InitializePlaywright()
        {
            //Playwright
            using var playwright = await Playwright.CreateAsync();
            //Browser
            _browser = await playwright.Chromium.LaunchAsync(new BrowserTypeLaunchOptions
            {
                Headless = false
            });
            //Page
            return await _browser.NewPageAsync();
        }

        public void Dispose() => _browser?.CloseAsync();
    }
}