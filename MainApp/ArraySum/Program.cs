using System;

namespace ArraySum
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] randomArr = new int[5];
            int[] handmadeArr = new int[5];
            int[] finalArr = new int[5];

            void FillRandomArr()
            {
                for (int i = 0; i < randomArr.Length; i++)
                {
                    Random rndNum = new Random();
                    randomArr[i] = rndNum.Next(100);

                    Console.Write("{0} ", randomArr[i]);
                }
                Console.WriteLine('\n');
            }

            void FillHandmadeArr()
            {
                for (int i = 0; i < handmadeArr.Length; i++)
                {
                    Console.WriteLine($"Input {i + 1} number:");
                    handmadeArr[i] = Convert.ToInt32(Console.ReadLine());
                }

                for (int i = 0; i < handmadeArr.Length; i++)
                {
                    Console.Write("{0} ", handmadeArr[i]);
                }
                Console.WriteLine('\n');
            }

            void SumFinalArr()
            {
                Console.WriteLine("Sum of two arrays:");

                for (int i = 0; i < finalArr.Length; i++)
                {
                    finalArr[i] = handmadeArr[i] + randomArr[i];
                    Console.Write("{0} ", finalArr[i]);
                }
            }

            FillHandmadeArr();
            FillRandomArr();
            SumFinalArr();

            Console.Read();
        }
    }
}
