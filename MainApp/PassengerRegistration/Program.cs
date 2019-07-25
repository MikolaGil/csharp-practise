using System;

namespace PassengerRegistration
{
    class Program
    {
        static void Main(string[] args)
        {
            PassengerGreeting greeting = new PassengerGreeting();
            Console.WriteLine(greeting.Message());
            PassengerInfo passengerInfo = new PassengerInfo();
            passengerInfo.GetPassengerInfo();
            bool test = passengerInfo.CheckData();
            if (test)
            {
                Console.WriteLine("Stiil work");
                Console.ReadLine();
            }
            else
            {
                passengerInfo.GetPassengerInfo();
            }
        }
    }
}
