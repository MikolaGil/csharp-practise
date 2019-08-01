using System;

namespace PassengerRegistration
{
    class OnBoardRegistration
    {
        int _ticketNum;
        string _seat;
        string[] seats = { "A", "B", "C", "D", "E", "F" };

        public string GeneratePassengerTicket(int maxRows)
        {
            Random rndm = new Random();
            _ticketNum = rndm.Next(1, maxRows);
            _seat = seats[2];
            return Convert.ToString(_ticketNum + _seat);
        }

        public string GeneratePassengerTicket (string Airplane)
        {
            Random rndm = new Random();
            _ticketNum = rndm.Next(1, 30);
            _seat = seats[2];
            return Convert.ToString($"{Airplane} - {_ticketNum}{_seat}");
        }
    }
}
