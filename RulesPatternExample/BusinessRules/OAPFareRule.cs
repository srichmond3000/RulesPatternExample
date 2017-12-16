using System;
namespace RulesPatternExample.BusinessRules
{
    public class OAPFareRule : IFareRule
    {
        public OAPFareRule()
        {
        }

        public decimal Evaluate(Passenger passenger, DateTime journeyTime, decimal fare)
        {
            decimal evaluatedFare = passenger.DateOfBirth.AddYears(60) >= DateTime.Now
                                             ? fare * 0.45m
                                             : fare;

            return evaluatedFare;
        }
    }
}
