using System;
namespace RulesPatternExample.BusinessRules
{
    public interface IFareRule
    {
        decimal Evaluate(Passenger passenger, DateTime journeyTime, decimal fare);
    }
}
