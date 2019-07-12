using System;

namespace Bacteria
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter the number of minutes:");
            int minutes = Convert.ToInt32(Console.ReadLine());

            double numberOfBacterias = Math.Pow(2, minutes);

            Console.WriteLine("Bacterias amount: " + numberOfBacterias);
            Console.Read();
        }
    }
}
