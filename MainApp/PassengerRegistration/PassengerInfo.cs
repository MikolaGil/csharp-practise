using System;
using System.Collections.Generic;
using System.Text;

namespace PassengerRegistration
{
    class PassengerInfo
    {
        private string _name;
        private string _surname;
        private string _ticket;
        private string _baggage;
        public void GetPassengerInfo()
        {
            Console.WriteLine(Constants.RegistrationQuestions.PassengerName);
            _name = Console.ReadLine();
            Console.WriteLine(Constants.RegistrationQuestions.PassengerSurname);
            _surname = Console.ReadLine();
            Console.WriteLine(Constants.RegistrationQuestions.PassengerTicket);
            _ticket = Console.ReadLine();
            Console.WriteLine(Constants.RegistrationQuestions.PassengerBaggage);
            _baggage = Console.ReadLine();
        }
        
        public bool CheckData()
        {
            Console.WriteLine("Everything correct?");
            Console.WriteLine($"Name:{_name}\nSurname:{_surname}\nTicket:{_ticket}\nYes, No(Y\\N)?");
            string value = Console.ReadLine().ToUpper();

            bool result = value == "Y"? true: false;
            return result;
        }
    }
}
