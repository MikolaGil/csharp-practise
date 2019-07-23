using System;

namespace ArrMaxValue
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] arr = new int[13];

            for (int i = 0; i < arr.Length; i++)
            {
                Random random = new Random();
                arr[i] = random.Next(1, 101);
            }

            for (int i = 0; i < arr.Length; i++)
                Console.Write($"{arr[i]} ");

            GetMaxValue(arr);

            Console.ReadLine();
        }

        static void GetMaxValue(int[] array)
        {
            int maxVal = 0;

            for (int i = 0; i < array.Length; i++)
            {
                if (array[i] > maxVal)
                    maxVal = array[i];
            }

            Console.WriteLine("\nMax value: {0}", maxVal);
        }
    }
}
