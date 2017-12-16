using System;
using RulesPatternExample.BusinessRules;

namespace RulesPatternExample
{
    class Program
    {
        static void Main(string[] args)
        {
            FareRuleEngineBuilder ruleEngineBuilder = new FareRuleEngineBuilder();
            FareRuleEngine ruleEngine = ruleEngineBuilder
                .WithOAPRule().WithStudentRule()
                .WithPeakRule(TimeSpan.FromHours(7.5), TimeSpan.FromHours(9.0))
                .Build();
            Passenger passenger = GetPassenger();
            DateTime journeyTime = new DateTime(2017, 12, 16, 8, 23, 2);
            decimal basicFare = 5.00m;
            decimal fare = ruleEngine.Evaluate(passenger, journeyTime, basicFare);

            Console.WriteLine($"Fare is: {fare}");
            Console.Read();
        }

        private static Passenger GetPassenger()
        {
            return new Passenger(new DateTime(1932, 10, 12), true);
        }
    }
}
