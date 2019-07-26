using System;

namespace PassengerRegistration
{
    class OnBoardRegistration
    {
        int ticketNum;
        string seat;
        string[] seats = { "A", "B", "C", "D", "E", "F" };
        public string GeneratePassengerTicket(int maxRows)
        {
            Random rndm = new Random();
            ticketNum = rndm.Next(1, maxRows);
            seat = seats[2];
            return Convert.ToString(ticketNum + seat);
        }

        public string GeneratePassengerTicket (string Airplane)
        {
            Random rndm = new Random();
            ticketNum = rndm.Next(1, 30);
            seat = seats[2];
            return Convert.ToString(Airplane + " - " + ticketNum + seat);
        }
    }
}
