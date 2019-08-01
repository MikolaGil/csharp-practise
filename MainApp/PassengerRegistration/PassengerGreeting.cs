using System;

namespace PassengerRegistration
{
    class PassengerGreeting
    {
        public string Message()
        {
            TimeSpan currentTime = DateTime.Now.TimeOfDay;
            int currentHour = currentTime.Hours;
            string message;

            if (currentHour > 9 && currentHour <= 12)
            {
                return message = Constants.Greeting.GoodMorning + Constants.Greeting.GreetingMsg;
            }
            else if (currentHour > 12 && currentHour <= 15)
            {
                return message = Constants.Greeting.GoodAfternoon + Constants.Greeting.GreetingMsg;
            }
            else if (currentHour > 15 && currentHour <= 22)
            {
                return message = Constants.Greeting.GoodEvening + Constants.Greeting.GreetingMsg;
            }
            else
            {
                return message = Constants.Greeting.GoodEvening + Constants.Greeting.GreetingMsg;
            }
        }
    }
}
