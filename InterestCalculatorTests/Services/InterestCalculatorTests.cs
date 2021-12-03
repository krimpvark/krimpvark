using InterestCalculator;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;

namespace InterestCalculator.Tests
{
    [TestClass()]
    public class InterestCalculatorTests
    {
        [TestMethod()]
        public void InterestreceivedTest()
        {
            InterestCalculator calc = new InterestCalculator();

            decimal val = calc.InterestReceived(100.0m, 0.1m, DateTime.Now.AddDays(-10.0), DateTime.Now);

            Assert.AreEqual(val, 101.10551653304624623301650550m);
        }

        [TestMethod()]
        public void InterestDailyTest()
        {
            InterestCalculator calc = new InterestCalculator();

            decimal val = calc.InterestDaily(100.0m, 0.1m, DateTime.Now.AddDays(-10.0), DateTime.Now);

            Assert.AreEqual(val, 100.11005501650330046204620330m);
        }

        /// <summary>
        /// This is what a default test looks like
        /// </summary>
        [TestMethod()]
        public void InterestExampleTest()
        {
            Assert.Fail();
        }
    }
}