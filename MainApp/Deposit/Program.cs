using System;

namespace Deposit
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter the number of months: ");

            int month = Convert.ToInt32(Console.ReadLine());
            double sum = 1000;

            for (int i = 1; i <= month; i++)
            {
                double percent = sum * 0.02;
                sum += percent;
            }

            Console.WriteLine($"Bank account balanсe: {sum}");
            Console.Read();
        }
    }
}
