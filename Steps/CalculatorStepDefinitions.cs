using TechTalk.SpecFlow.Assist;

namespace BDDwithSpecflow.Steps;

[Binding]
public sealed class CalculatorStepDefinitions
{
    // For additional details on SpecFlow step definitions see https://go.specflow.org/doc-stepdef

    private readonly ScenarioContext _scenarioContext;

    public CalculatorStepDefinitions(ScenarioContext scenarioContext)
    {
        _scenarioContext = scenarioContext;
    }

    [Given("the first number is (.*)")]
    public void GivenTheFirstNumberIs(int number)
    {
        //TODO: implement arrange (precondition) logic
        // For storing and retrieving scenario-specific data see https://go.specflow.org/doc-sharingdata
        // To use the multiline text or the table argument of the scenario,
        // additional string/Table parameters can be defined on the step definition
        // method. 
        
        Console.WriteLine("First number is " + number);
        _scenarioContext["Number1"] = number;
        _scenarioContext.Add("key",new object());
        var aaa = _scenarioContext.Get<object>("key");

        //_scenarioContext.Pending();
    }

    [Given("the second number is (.*)")]
    public void GivenTheSecondNumberIs(int number)
    {
        //TODO: implement arrange (precondition) logic
        // For storing and retrieving scenario-specific data see https://go.specflow.org/doc-sharingdata
        // To use the multiline text or the table argument of the scenario,
        // additional string/Table parameters can be defined on the step definition
        // method. 
        
        Console.WriteLine("First Given parameter is " + _scenarioContext["Number1"]);
        Console.WriteLine("Second number is " + number);

       // _scenarioContext.Pending();
    }

    [When("the two numbers are added")]
    public void WhenTheTwoNumbersAreAdded()
    {
        //TODO: implement act (action) logic

        //_scenarioContext.Pending();
    }

    [Then("the result should be (.*)")]
    public void ThenTheResultShouldBe(int result)
    {
        //TODO: implement assert (verification) logic

        //_scenarioContext.Pending();
    }

    [Given(@"I enter the following number")]
    public void GivenIEnterTheFollowingNumber(Table table)
    {
        var firstDataString = table.Rows[0]["number"];
        Console.WriteLine($"firstDataString : {firstDataString}");
        
        var firstDataDigit = table.Rows[0]["digits"];
        Console.WriteLine($"firstDataDigit : {firstDataDigit}");
        
        //ScenarioContext.StepIsPending();

        object obj = table.CreateSet<object>();
        dynamic datas = table.CreateDynamicSet();
        foreach (var data in datas)
        {
            Console.WriteLine($"The number is {data.number} : {data.digits}");
        }
    }
}