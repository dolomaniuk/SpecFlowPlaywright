namespace SpecFlowPlaywright.Steps;

[Binding]
public sealed class EAAppTestSteps
{
    // For additional details on SpecFlow step definitions see https://go.specflow.org/doc-stepdef

    private readonly ScenarioContext _scenarioContext;

    public EAAppTestSteps(ScenarioContext scenarioContext)
    {
        _scenarioContext = scenarioContext;
    }

    [Given(@"I navigate to application")]
    public void GivenINavigateToApplication()
    {
        ScenarioContext.StepIsPending();
    }

    [Given(@"I click login link")]
    public void GivenIClickLoginLink()
    {
        ScenarioContext.StepIsPending();
    }

    [Given(@"I enter following login details")]
    public void GivenIEnterFollowingLoginDetails(Table table)
    {
        ScenarioContext.StepIsPending();
    }

    [Then(@"I see Employee List")]
    public void ThenISeeEmployeeList()
    {
        ScenarioContext.StepIsPending();
    }
}