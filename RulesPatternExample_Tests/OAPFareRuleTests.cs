using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using RulesPatternExample;
using RulesPatternExample.BusinessRules;
using RulesPatternExample.Tests;

namespace RulesPatternExample_Tests
{
    [TestClass]
    public class OAPFareRuleTests
    {
        [TestMethod]
        public void EvaluateOAPReturnsCorrectFare()
        {
            Passenger passenger = new PassengerBuilder().OAP70YearOld().Build();
            DateTime journeyTime = DateTime.Now;
            decimal fare = 5.00m;

            decimal evaluatedFare = new OAPFareRule().Evaluate(passenger, journeyTime, fare);

            Assert.AreEqual((fare * 0.45m), evaluatedFare);
        }
    }
}
