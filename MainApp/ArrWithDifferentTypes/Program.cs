using System;

namespace ArrWithDifferentTypes
{
    class Program
    {
        static void Main(string[] args)
        {
            object[] array = new object[3] { 32, 'A', "Hello" };

            for (int i = 0; i < array.Length; i++)
                Console.Write($"{array[i]}\t");

            Console.WriteLine();

            array[0] = (int)array[0] + 10;
            array[2] = array[2] + ", guys";

            for (int i = 0; i < array.Length; i++)
                Console.Write($"{array[i]}\t");

            Console.Read();
        }
    }
}
