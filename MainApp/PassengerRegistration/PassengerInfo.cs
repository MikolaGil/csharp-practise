using System;

namespace PassengerRegistration
{
    class PassengerInfo
    {
        private string _name;
        private string _surname;
        private string _baggage;
        public void GetPassengerInfo()
        {
            Console.WriteLine(Constants.RegistrationQuestions.PassengerName);
            _name = Console.ReadLine();
            Console.WriteLine(Constants.RegistrationQuestions.PassengerSurname);
            _surname = Console.ReadLine();
            Console.WriteLine(Constants.RegistrationQuestions.PassengerBaggage);
            _baggage = Console.ReadLine();
        }
        
        public bool CheckData()
        {
            Console.WriteLine("Everything correct?");
            Console.WriteLine($"Name:{_name}\nSurname:{_surname}\nYes, No(Y\\N)?");
            string value = Console.ReadLine().ToUpper();

            bool result = value == "Y"? true: false;
            return result;
        }
    }
}
