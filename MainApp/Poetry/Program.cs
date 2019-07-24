using System;

namespace Poetry
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Input a poetry:");
            string text = Console.ReadLine().ToUpper();

            string[] arrText = text.Split(';');

            for (int i = 0; i <arrText.Length; i++)
            {
                arrText[i] = arrText[i].Replace('O', 'A');
                Console.WriteLine(arrText[i].ToLower());
            }

            Console.ReadLine();
        }
    }
}
