using System;

namespace Reverse
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] arr1 = new int[] { 1, 2, 3, 4, 5 };
            int[] reverseArr = new int[arr1.Length];

            for (int i = arr1.Length - 1, j = 0; i >= 0 && i < arr1.Length; i--, j++)
            {
                reverseArr[i] = arr1[j];
            }

            arr1 = reverseArr;

            foreach (int item in arr1)
            {
                Console.WriteLine(item);
            }
            Console.Read();
        }
    }
}
