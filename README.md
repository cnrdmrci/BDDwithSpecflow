# Behavior Driven Development

Behavior Driven Development is a software development approach that it aims to bridge the gap between business analyst and developers. BDD allows to create test cases in simple text language

There are many tools available to support BDD and we will use Specflow BDD.

Specflow BDD tool uses Gherkin language


## Gherkin Syntax
- Feature
  ```gherkin
  Feature: Login Control
      Check passwords are equal
      Add login log
  ```
  
- Background
  ```gherkin
  Background:
      Given User has already created before starting scenario
  ```
  
- Scenario
- Given
- When
- Then
- And
- But
  ```gherkin
  Scenario:
      Given Get password from first password field
      And Get password retry from second password field
      When Click login button
      Then Compare passwords are equal
      And Add log
  ```

- Scenario Outline
- Examples
  ```gherkin
  Scenario Outline: Show result
      Then Number: <number> , Name: <name>

  Examples: 
    | number | name  |
    | 1      | can   |
    | 2      | caner |
  ```

## Table Usage
  ```gherkin
  Scenario: Add two numbers
    Given the first number is 50
    And I enter the following number
      | number | digits |
      | one    | 1      |
      | two    | 2      |
      | three  | 3      |
    And the second number is 70
    When the two numbers are added
    Then the result should be 120
  ```
  
  ```c#
  [Given(@"I enter the following number")]
  public void GivenIEnterTheFollowingNumber(Table table)
  {
      var firstDataString = table.Rows[0]["number"];
      Console.WriteLine($"firstDataString : {firstDataString}");

      var firstDataDigit = table.Rows[0]["digits"];
      Console.WriteLine($"firstDataDigit : {firstDataDigit}");

      object obj = table.CreateSet<object>();
      dynamic datas = table.CreateDynamicSet(); //SpecFlow.Assist.Dynamic
      foreach (var data in datas)
      {
          Console.WriteLine($"The number is {data.number} : {data.digits}");
      }
  }
  ```

## Scenario Context
  ```c#
  private readonly ScenarioContext _scenarioContext;
  _scenarioContext["Number1"] = number;
  _scenarioContext.Add("key",new object());
  var myObject = _scenarioContext.Get<object>("key");
  Console.WriteLine("First Given parameter is " + _scenarioContext["Number1"]);
  ```
  
## Hooks - Binding
  ```c#
  [Binding]
  public class Hooks
  {
      [BeforeScenario]
      public static void BeforeScenario()
      {
          Console.WriteLine("Before Scenario runned.");
      }

      [AfterScenario]
      public static void AfterScenario()
      {
          Console.WriteLine("After Scenario runned.");
      }
  }
  ```
  
## Scoped Binding
  ```gherkin
  Feature: Test_Feature
      bla bla
      
  @scenarioTag
  Scenario: Add two numbers
    Given the first number is 50
    And I enter the following number
      | number | digits |
      | one    | 1      |
      | two    | 2      |
      | three  | 3      |
    And the second number is 70
    When the two numbers are added
    Then the result should be 120
  ```
  ```c#
  [Given("the first number is (.*)")]
  [Scope(Feature = "Test_Feature")]
  [Scope(Tag = "scenarioTag")]
  public void FirstNumberIsX()
  {
      //.....
  }
  ```






