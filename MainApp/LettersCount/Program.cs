using System;

namespace LettersCount
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Input word:");
            string text = Console.ReadLine().ToUpper();
            int count = 0;

            foreach (char letter in text)
            {
                if (letter == 'A')
                {
                    count++;
                }
            }

            if (count == 0)
            {
                Console.WriteLine("There is no 'A' letters in word");
            }
            else
            {
                Console.WriteLine(count);
            }

            Console.Read();
        }
    }
}
