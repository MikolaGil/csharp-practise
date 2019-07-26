using System;

namespace PassengerRegistration
{
    public class Passenger
    {
        PassengerGreeting greeting = new PassengerGreeting();
        PassengerInfo passengerInfo = new PassengerInfo();
        bool CheckData;
        bool security;
        string ticket;

        public void PassengerCheckIn()
        {
            try
            {
                Console.WriteLine(greeting.Message());
                passengerInfo.GetPassengerInfo();
                CheckData = passengerInfo.CheckData();

                if (CheckData)
                {
                    security = Security.SecurityQuestions();
                }
                else
                {
                    passengerInfo.GetPassengerInfo();
                }

                if (security)
                {
                    OnBoardRegistration onBoard = new OnBoardRegistration();
                    ticket = onBoard.GeneratePassengerTicket(30);
                    Console.WriteLine(Constants.OnBoardRegistrationQuestions.SeatNumber, ticket);
                    Console.WriteLine(Constants.OnBoardRegistrationQuestions.HaveGoodFligth);
                    Console.ReadLine();
                }
                else
                {
                    Console.WriteLine(Constants.SecurityQuestions.Problems);
                    Console.ReadLine();
                    Environment.Exit(1);
                }
            }
            catch (Exception ex)
            {

                Console.WriteLine("You enter wrong data");
                Console.ReadKey();
            }

        }
    }
}
