@Calculator
Feature: Calculator
	As a student
	I want to be able to perform basic arithmetic operations
	In order to get high score on tests

@Sum
@Smoke
Scenario: Calculator - Check Sum
	Given I provide number 2 into calculator
	And I provide number 2 into calculator
	When I get Sum of numbers entered
	Then Result of calculation is 4

@Sum
@Smoke
Scenario: Calculator - Check Mult
	Given I provide number 2 into calculator
	And I provide number 2 into calculator
	When I get 'Mult' of numbers entered
	Then Result of calculation is 4

@Diff
@Smoke
Scenario Outline: Calculator - Check Diff
	Given I provide number <operand1> into calculator
	And I provide number <operand2> into calculator
	When I get Diff of entered numbers
	Then Result of calculation is <result>

Examples: 
| operand1 | operand2 | result |
| 2        | 1        | 1      |
| 8        | 3        | 4      |
| 14       | 4        | 10     |

@Sum
@Smoke
Scenario: Calculator - Check Div
	Given I provide number 2 into calculator
	And I provide number 2 into calculator
	When I get 'Div' of numbers entered
	And I remember the result of calculation

	Given I provide number 2 into calculator
	And I provide number 2 into calculator
	When I get 'Div' of numbers entered
	And I remember the result of calculation

	Then I check that collection of results contains 2 items
