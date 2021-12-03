using NUnit.Framework;
using System;

namespace InterestCalculator.Tests
{
    [TestFixture()]
    public class InterestCalculatorTests
    {
        [Test()]
        public void InterestExampleTest()
        {
            Assert.Fail();
        }

        [Test()]
        public void InterestDailyTest()
        {
            InterestCalculator calc = new InterestCalculator();

            decimal val = calc.InterestDaily(100.0m, 0.1m, DateTime.Now.AddDays(-10.0), DateTime.Now);

            Assert.That(val, Is.EqualTo(100.11005501650330046204620330m));
        }

        [Test()]
        public void InterestReceivedTest()
        {
            InterestCalculator calc = new InterestCalculator();

            decimal val = calc.InterestReceived(100.0m, 0.1m, DateTime.Now.AddDays(-10.0), DateTime.Now);

            Assert.That(val, Is.EqualTo(101.10551653304624623301650550m));
        }
    }
}