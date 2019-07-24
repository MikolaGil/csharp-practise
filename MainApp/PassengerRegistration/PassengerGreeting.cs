using System;
using System.Collections.Generic;
using System.Text;

namespace PassengerRegistration
{
    class PassengerGreeting
    {
        private string _greeting;
        public string Greeting
        {
            get
            {
                return _greeting;
            }

            set
            {
                TimeSpan currentTime = DateTime.Now.TimeOfDay;
                int currentHour = currentTime.Hours;

                if (currentHour > 9 && currentHour <= 12)
                {
                    _greeting = Constants.GreetingMsg + Constants.GoodMorning;
                }
                else if (currentHour > 12 && currentHour <= 15)
                {
                    _greeting = Constants.GreetingMsg + Constants.GoodAfternoon;
                }
                else if (currentHour > 15 && currentHour <= 22)
                {
                    _greeting = Constants.GreetingMsg + Constants.GoodMorning;
                }
                else
                {
                    _greeting = Constants.GreetingMsg + Constants.GoodEvening;
                }
            }
        }

        //public string test()
        //{
        //    return _greeting;
        //}
    }
}
