using System;
using System.Collections.Generic;

namespace RulesPatternExample.BusinessRules
{
    public class FareRuleEngine : IFareRule
    {
        public FareRuleEngine(List<IFareRule> fareRules)
        {
            FareRules = fareRules;
        }

        public List<IFareRule> FareRules
        {
            get;
            private set;
        }

        public decimal Evaluate(Passenger passenger, DateTime journeyTime, decimal fare)
        {
            decimal evaluatedFare = fare;

            FareRules.ForEach(rule => 
            {
                evaluatedFare = Math.Min(rule.Evaluate(passenger, journeyTime, fare), evaluatedFare);
            });

            return evaluatedFare;
        }
    }
}
