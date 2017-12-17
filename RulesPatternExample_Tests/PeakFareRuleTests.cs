using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using RulesPatternExample;
using RulesPatternExample.BusinessRules;
using RulesPatternExample.Tests;

namespace RulesPatternExample_Tests
{
    [TestClass]
    public class PeakFareRuleTests
    {
        [TestMethod]
        public void EvaluatePeakReturnsCorrectFare()
        {
            Passenger passenger = new PassengerBuilder().NonStudent30YearOld().Build();
            DateTime journeyTime = DateTime.Now;
            DateTime peakStart = journeyTime.AddHours(-1);
            DateTime peakEnd = journeyTime.AddHours(1);
            decimal fare = 5.00m;

            decimal evaluatedFare = new PeakFareRule(peakStart.TimeOfDay, peakEnd.TimeOfDay)
                .Evaluate(passenger, journeyTime, fare);

            Assert.AreEqual((fare * 1.2m), evaluatedFare);
        }

        [TestMethod]
        public void EvaluateNonPeakReturnsCorrectFare()
        {
            Passenger passenger = new PassengerBuilder().NonStudent30YearOld().Build();
            DateTime journeyTime = DateTime.Now;
            DateTime peakStart = journeyTime.AddHours(-2);
            DateTime peakEnd = journeyTime.AddHours(-1);
            decimal fare = 5.00m;

            decimal evaluatedFare = new PeakFareRule(peakStart.TimeOfDay, peakEnd.TimeOfDay)
                .Evaluate(passenger, journeyTime, fare);

            Assert.AreEqual(fare, evaluatedFare);
        }
    }
}
