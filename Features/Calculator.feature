Feature: Calculator
![Calculator](https://specflow.org/wp-content/uploads/2020/09/calculator.png)
Simple calculator for adding **two** numbers

Link to a feature: [Calculator]($projectname$/Features/Calculator.feature)
***Further read***: **[Learn more about how to generate Living Documentation](https://docs.specflow.org/projects/specflow-livingdoc/en/latest/LivingDocGenerator/Generating-Documentation.html)**

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

Scenario Outline: Show result
    Then the result should be <number>

Examples: 
  | number |
  | 1      |
  | 2      |
  | 3      |