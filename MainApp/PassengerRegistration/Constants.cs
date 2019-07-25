using System;

namespace PassengerRegistration
{
    public class Constants
    {
        public class Greeting {
            public const string GreetingMsg = "We glad to see you in our airport! Please, enter information about you.";
            public const string GoodMorning = "Good morning! ";
            public const string GoodAfternoon = "Good afternoon! ";
            public const string GoodEvening = "Good evening! ";
            public const string GoodNight = "Good night! ";
        }

        public class RegistrationQuestions
        {
            public const string PassengerName = "Name: ";
            public const string PassengerSurname = "Surname: ";
            public const string PassengerTicket = "Ticket Number: ";
            public const string PassengerBaggage = "Do you have baggage?(Y\\N)";
        }
    }
}
