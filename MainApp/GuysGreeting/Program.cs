using System;

namespace GuysGreeting
{
    class Program
    {
        static void Main(string[] args)
        {
            TimeSpan currentTime = DateTime.Now.TimeOfDay;

            int currentHour = currentTime.Hours;

            if (currentHour > 9 && currentHour <= 12)
            {
                Console.WriteLine("Good Morning, Guys");
            }
            else if (currentHour > 12 && currentHour <= 15)
            {
                Console.WriteLine("Good day, Guys");
            }
            else if (currentHour > 15 && currentHour <= 22)
            {
                Console.WriteLine("Good Evening, Guys");
            }
            else
            {
                Console.WriteLine("Sweet Dreams, Guys");
            }

            Console.ReadLine();
        }
    }
}
