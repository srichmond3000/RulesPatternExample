﻿/*using System;
using RulesPatternExample.BusinessRules;

namespace RulesPatternExample.Tests
{
    [TestClass]
    public class SudentFareRuleTests
    {
        [TestMethod]
        public void EvaluateReturnsHalfFarem()
        {
            Passenger passenger = new PassengerBuilder().Student20YearOld().Build();
            DateTime journeyTime = DateTime.Now;
            decimal fare = 5.00m;

            decimal evaluatedFare = new StudentFareRule().Evaluate(passenger, journeyTime, fare);

            Assert.AreEqual((fare / 2.0m), fare);
        }
    }
}
*/