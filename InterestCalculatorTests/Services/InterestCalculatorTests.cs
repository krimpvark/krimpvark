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

            decimal val = calc.Interestreceived(100.0m, 0.1m, DateTime.Now.AddDays(-1.0), DateTime.Now);

            Assert.AreEqual(val, 100.2001m);
        }
    }
}