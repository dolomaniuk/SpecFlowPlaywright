using FluentAssertions;
using SpecFlowPlaywright.Drivers;
using SpecFlowPlaywright.Pages;
using TechTalk.SpecFlow.Assist;

namespace SpecFlowPlaywright.Steps;

[Binding]
public sealed class EAAppTestSteps
{
    private readonly Driver _driver;
    private readonly LoginPage _loginPage;

    public EAAppTestSteps(Driver driver)
    {
        _driver = driver;
        _loginPage = new LoginPage(_driver.Page);
    }

    [Given(@"I navigate to application")]
    public void GivenINavigateToApplication()
    {
        _driver.Page.GotoAsync("http://www.eaapp.somee.com");
    }

    [Given(@"I click login link")]
    public async Task GivenIClickLoginLink()
    {
        await _loginPage.ClickLogin();
    }

    [Given(@"I enter following login details")]
    public async Task GivenIEnterFollowingLoginDetails(Table table)
    {
        dynamic data = table.CreateDynamicInstance();
        await _loginPage.Login((string)data.UserName, (string)data.Password);
    }

    [Then(@"I see Employee List")]
    public async Task ThenISeeEmployeeList()
    {
        var isExist = await _loginPage.isEmployeeDetailsExists();
        isExist.Should().Be(true);
    }
}