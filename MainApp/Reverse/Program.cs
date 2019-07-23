using System;
namespace Reverse
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] arr = new int[] { 1, 2, 3, 4, 5 };
            int[] reverseArr = new int[arr.Length];

            for (int i = arr.Length - 1, j = 0; i >= 0 && i < arr.Length; i--, j++)
            {
                reverseArr[i] = arr[j];
            }

            arr = reverseArr;

            foreach (int item in arr)
            {
                Console.WriteLine(item);
            }
            Console.Read();
        }
    }
}
