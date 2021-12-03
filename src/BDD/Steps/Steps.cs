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

        [When("the Interest rate is calculated")]
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
