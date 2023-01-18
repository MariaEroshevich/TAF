using System.Collections.Generic;
using Epam.TestAutomation.Core.ContextHelper;
using Epam.TestAutomation.Utilities;
using NUnit.Framework;
using TechTalk.SpecFlow;

namespace Epam.TestAutomation.BDD
{
    [Binding]
    public class CalculatorSteps
    {
        private Calculator Calculator = new();

        [StepDefinition(@"I provide number (.*) into calculator")]
        public void GivenIProvideNumberIntoCalculator(double operand)
        {
            Calculator.EnterOperand(operand);
        }

        [When(@"I get Sum of numbers entered")]
        public void WhenIGetSumOfNumbersEntered()
        {
            Calculator.Sum();
        }

        [When(@"I get Diff of entered numbers")]
        public void WhenIGetDiffOfEnteredNumbers()
        {
            Calculator.Diff();
        }

        [When(@"I get Mult of numbers entered")]
        public void WhenIGetMultOfNumbersEntered()
        {
            Calculator.Mult();
        }


        [When(@"I get Div of numbers entered")]
        public void WhenIGetDivOfNumbersEntered()
        {
            Calculator.Div();
        }

        [When(@"I get '(Diff|Mult|Sum|Div)' of numbers entered")]
        public void WhenIGetOfNumbersEntered(string action)
        {
            switch (action)
            {
                case "Diff":
                    WhenIGetDiffOfEnteredNumbers();
                    break;
                case "Mult":
                    WhenIGetMultOfNumbersEntered();
                    break;
                case "Sum":
                    WhenIGetSumOfNumbersEntered();
                    break;
                case "Div":
                    WhenIGetDivOfNumbersEntered();
                    break;
            }
        }

        [Then(@"Result of calculation is (.*)")]
        public void ThenResultOfCalculationIs(double expectedResult)
        {
            Assert.That(Calculator.Result, Is.EqualTo(expectedResult), "Invalid calculation result!");
        }

        [When(@"I remember the result of calculation")]
        public void WhenIRememberTheResultOfCalculation()
        {
            var contextVar = ContextVariables.CalculationResults;
            if (!ContextVariableHelper.IsValueExist(contextVar))
                ContextVariableHelper.SetValueToContext(contextVar, new List<double>());

            var actualResults = ContextVariableHelper.GetValueFromContext<List<double>>(contextVar);
            actualResults.Add(Calculator.Result);
        }

        [Then(@"I check that collection of results contains (.*) items")]
        public void ThenICheckThatCollectionOfResultsContainsItems(int expectedNumberOfItems)
        {
            var contextVar = ContextVariables.CalculationResults;

            var resultList = ContextVariableHelper.GetValueFromContext<List<double>>(contextVar);

            Assert.That(resultList, Has.Count.EqualTo(expectedNumberOfItems), "Invalid number of results present!");
        }

    }
}
