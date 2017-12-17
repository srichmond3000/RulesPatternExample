using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using RulesPatternExample;
using RulesPatternExample.BusinessRules;
using RulesPatternExample.Tests;

namespace RulesPatternExample_Tests
{
    [TestClass]
    public class SudentFareRuleTests
    {
        [TestMethod]
        public void EvaluateReturnsCorrectFare()
        {
            Passenger passenger = new PassengerBuilder().Student20YearOld().Build();
            DateTime journeyTime = DateTime.Now;
            decimal fare = 5.00m;

            decimal evaluatedFare = new StudentFareRule().Evaluate(passenger, journeyTime, fare);

            Assert.AreEqual((fare / 2.0m), evaluatedFare);
        }
    }
}
