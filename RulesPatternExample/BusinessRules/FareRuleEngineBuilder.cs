using System;
using System.Collections.Generic;

namespace RulesPatternExample.BusinessRules
{
    public class FareRuleEngineBuilder
    {
        private List<IFareRule> _fareRules;

        public FareRuleEngineBuilder()
        {
            _fareRules = new List<IFareRule>();
        }

        public FareRuleEngineBuilder WithStudentRule()
        {
            _fareRules.Add(new StudentFareRule());
            return this;
        }

        public FareRuleEngineBuilder WithOAPRule()
        {
            _fareRules.Add(new OAPFareRule());
            return this;
        }

        public FareRuleEngineBuilder WithPeakRule(TimeSpan peakTimeStart, TimeSpan peakTimeEnd)
        {
            _fareRules.Add(new PeakFareRule(peakTimeStart, peakTimeEnd));
            return this;
        }

        public FareRuleEngine Build()
        {
            return new FareRuleEngine(_fareRules);
        }
    }
}
