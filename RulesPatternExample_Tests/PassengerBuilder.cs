using System;
namespace RulesPatternExample.Tests
{
    public class PassengerBuilder
    {
        private Passenger _passenger;

        public PassengerBuilder()
        {
            _passenger = new Passenger(DateTime.Now.AddYears(-30), false);
        }

        public PassengerBuilder NonStudent30YearOld()
        {
            return this;
        }

        public PassengerBuilder Student20YearOld()
        {
            _passenger = new Passenger(DateTime.Now.AddYears(-20), true);
            return this;
        }

        public PassengerBuilder OAP70YearOld()
        {
            _passenger = new Passenger(DateTime.Now.AddYears(-70), false);
            return this;
        }

        public Passenger Build()
        {
            return _passenger;
        }
    }
}
