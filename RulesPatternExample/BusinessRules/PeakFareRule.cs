using System;
namespace RulesPatternExample.BusinessRules
{
    public class PeakFareRule : IFareRule
    {
        public PeakFareRule(TimeSpan peakTimeStart, TimeSpan peakTimeEnd)
        {
            PeakTimeStart = peakTimeStart;
            PeakTimeEnd = peakTimeEnd;
        }

        public TimeSpan PeakTimeStart
        {
            get;
            private set;
        }

        public TimeSpan PeakTimeEnd
        {
            get;
            private set;
        }

        public decimal Evaluate(Passenger passenger, DateTime journeyTime, decimal fare)
        {
            decimal evaluatedFare = fare;

            if(journeyTime.TimeOfDay > PeakTimeStart && journeyTime.TimeOfDay < PeakTimeEnd)
            {
                evaluatedFare = fare * 1.2m;
            }

            return evaluatedFare;
        }
    }
}
