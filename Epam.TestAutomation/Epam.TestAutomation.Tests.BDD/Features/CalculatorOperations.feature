Feature: CalculatorOperations
	As a student
	I want to learn how to perform basic Specflow operations
	In order to be able to automate more complex scenarios

@Smoke
@Learning
Scenario: Calculator - Sum
	Given I provide number 2 into calculator
	And I provide number 3 into calculator
	When I choose Sum operation
	Then Result of calculations should be 5

@Smoke
@Learning
Scenario: Calculator - Diff
	Given I provide number 2 into calculator
	And I provide number 3 into calculator
	When I choose Diff operation
	Then Result of calculations should be -1

@Smoke
@Learning
Scenario Outline: Calculator - Sum - Data Driven
	Given I provide number <operand1> into calculator
	And I provide number <operand2> into calculator
	When I choose Sum operation
	Then Result of calculations should be <result>
Examples: 
| operand1 | operand2 | result |
| 2        | 2        | 4      |
| 4        | 3        | 7      |
| 5        | 1        | 5      |

@Smoke
@Learning
Scenario: Calculator - Mult
	Given I provide number 2 into calculator
	And I provide number 3 into calculator
	When I choose 'Mult' operation
	Then Result of calculations should be 6

@Smoke
@Learning
Scenario: Calculator - Div
	Given I provide number 2 into calculator
	And I provide number 3 into calculator
	When I choose 'Div' operation
	Then I remember the result of calculations

	Given I provide number 2 into calculator
	And I provide number 3 into calculator
	When I choose 'Mult' operation
	Then I remember the result of calculations

	Then I check that collection of results contains 2 items