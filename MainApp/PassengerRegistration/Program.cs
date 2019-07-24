using System;

namespace PassengerRegistration
{
    class Program
    {
        static void Main(string[] args)
        {
            PassengerGreeting greeting = new PassengerGreeting();
            Console.WriteLine(greeting.Greeting);
            Console.ReadLine();
        }
    }
}
