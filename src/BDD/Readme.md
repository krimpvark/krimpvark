## BDD -> Behavior Driven Development
Bridge the gap between non-technical and technical people by collaborating on executable specifications.

Technologies Used: Specflow https://specflow.org/

#### What is BDD
In software engineering, behavior-driven development (BDD) is an agile software development process that encourages collaboration among developers, quality assurance testers, and customer representatives in a software project. It encourages teams to use conversation and concrete examples to formalize a shared understanding of how the application should behave. It emerged from test-driven development (TDD). Behavior-driven development combines the general techniques and principles of TDD with ideas from domain-driven design and object-oriented analysis and design to provide software development and management teams with shared tools and a shared process to collaborate on software development. 

Source: https://en.wikipedia.org/wiki/Behavior-driven_development

In our Example, we used an interest rate calculation method.

We started by creating a Feature File:

```yaml
Feature: InteristRate

![InteristRate]
Simple Calculation of Interist Rate

@InteristRate
Scenario: Calculate Interist Rate
	Given the opening balance is 100
	And the rate is 10
	And the startDate is 2021-05-01
	And the endDate is 2021-05-15
	When the Interist rate is calculated
	Then the result should be 417.7248169415651
```

This allows non-technical staff easily to evaluate the logic & provide developers with a simplified requirement. 

For a real world example, BA's & product owners would be able to define the feature scenarios for given features with validated results.

For the test case it self, it provides the developers a simplified framework to generate the relevant test cases for said feature.

```csharp
using FluentAssertions;
using System;
using TechTalk.SpecFlow;

namespace TDD_Katas.BDD
{
    [Binding]
    public sealed class StepsDefinition
    {
        private readonly InterestCalculator _interestCalculator;
        private decimal _balance;
        private decimal _rate;
        private DateTime _startDate;
        private DateTime _endDate;
        private decimal _result;
        public StepsDefinition(InterestCalculator interestCalculator)
        {
            _interestCalculator = interestCalculator;
        }

        [Given("the opening balance is (.*)")]
        public void GivenBalance(decimal balance)
        {
            _balance = balance;
        }

        [Given("the rate is (.*)")]
        public void GivenRate(decimal rate)
        {
            _rate = rate;
        }

        [Given("the startDate is (.*)")]
        public void GivenStartDate(DateTime startDate)
        {
           _startDate = startDate;
        }

        [Given("the endDate is (.*)")]
        public void GivenEndDate(DateTime endDate)
        {
            _endDate = endDate;
        }

        [When("the Interist rate is calculated")]
        public void CalculateResult()
        {
          _result = _interestCalculator.Interestreceived(_balance, _rate, _startDate, _endDate);
        }

        [Then("the result should be (.*)")]
        public void ThenTheResultShouldBe(decimal result)
        {
            _result.Should().Be(result);
        }
    }
}
```
Using Specflow in combination with FluentAssertions provides a simplified & readable unit test.

BDD, FTW! 
