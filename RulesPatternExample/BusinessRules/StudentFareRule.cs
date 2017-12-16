using System;
namespace RulesPatternExample.BusinessRules
{
    public class StudentFareRule : IFareRule
    {
        public StudentFareRule()
        {
        }

        public decimal Evaluate(Passenger passenger, DateTime journeyTime, decimal fare)
        {
            decimal evaluatedFare = passenger.IsStudent
                                             ? fare * 0.5m
                                             : fare;

            return evaluatedFare;
        }
    }
}
