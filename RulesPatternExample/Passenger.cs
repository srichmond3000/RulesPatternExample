using System;
namespace RulesPatternExample
{
    public class Passenger
    {
        public Passenger(DateTime dateOfBirth, bool isStudent)
        {
            DateOfBirth = dateOfBirth;
            IsStudent = isStudent;
        }

        public DateTime DateOfBirth
        {
            get;
            private set;
        }

        public bool IsStudent
        {
            get;
            private set;
        }
    }
}
