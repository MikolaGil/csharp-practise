using System;

namespace Age
{
    class Program
    {
        static void Main(string[] args)
        {
            int birthYear = 0;
            int birthMonth = 0;
            int currentYear = DateTime.Now.Year;
            int currentMonth = DateTime.Now.Month;

            void GetBirthDate()
            {
                Console.WriteLine("Enter your year of birth");
                birthYear = Convert.ToInt32(Console.ReadLine());

                Console.WriteLine("Enter your month of birth");
                birthMonth = Convert.ToInt32(Console.ReadLine());

                CheckDate();
            }

            void CountAge()
            {
                int age = 0;
                age = currentYear - birthYear;

                if (currentMonth >= birthMonth)
                {
                    age += 1;
                }

                Console.WriteLine($"You are {age} years old");
                Console.Read();
            }

            void CheckDate()
            {
                if (birthYear > currentYear || birthMonth > 12)
                {
                    Console.WriteLine("Incorrect data. Please, enter your date of birth one more time");
                    GetBirthDate();
                }
                else
                {
                    CountAge();
                }
            }

            GetBirthDate();
        }
    }
}
