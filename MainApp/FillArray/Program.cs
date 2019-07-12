using System;

namespace FillArray
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] arr = new int[5];

            void getNumsForArr()
            {
                for (int i = 0; i < arr.Length - 1; i++)
                {
                    Console.WriteLine($"Input {i +1} number:");
                    arr[i] = Convert.ToInt32(Console.ReadLine());
                }

                ShowArr();
            }

            void GetNumFromUser()
            {
                Console.WriteLine();
                Console.WriteLine("Input number:");
                int newNum = Convert.ToInt32(Console.ReadLine());

                Console.WriteLine("Select index in arr from 0 to " + (arr.Length - 1));
                int index = Convert.ToInt32(Console.ReadLine());

                for (int i = 0; i < arr.Length; i++)
                {
                    if(i == index)
                    {
                        int[] tempArr = new int[arr.Length + 1];
                        Array.Copy(arr, 0, tempArr, 0, arr.Length);
                        arr[i] = newNum;

                        for (int j = index + 1; j < tempArr.Length - 1; j++)
                        {
                            arr[j] = tempArr[j - 1];
                        }
                    }
                    else
                    {
                        Console.WriteLine("Wron number");
                    }
                }

                ShowArr();
            }

            void ShowArr()
            {
                foreach (int num in arr)
                {
                    Console.Write("{0} ", num);
                }
            }

            getNumsForArr();
            GetNumFromUser();

            Console.ReadLine();
        }
    }
}
