using System;
using System.Collections.Generic;
using System.Text;

namespace Rectangle
{
    class Rectangle
    {
        struct Rect
        {
            public int side;
            public Rect(int x)
            {
                this.side = x;
            }
        }
        public static void CreateArr()
        {
            Rect[] rectArr = new Rect[100];
            Random rand = new Random();

            for (int i = 0; i < rectArr.Length; i++)
            {
                int sideX = rand.Next(1, 11);

                Rect rect = new Rect(sideX);
                rectArr[i] = rect;
                Console.Write($"{sideX}\t");
            }
            Console.WriteLine();

            CompareRectangles(rectArr[0], rectArr);
        }

        private static void CompareRectangles(Rect firstElem, Rect[] arr)
        {
            Console.WriteLine($"First rectangle: X:{firstElem.side}");

            for (int i = 1; i < arr.Length; i++)
            {
                if (arr[i].Equals(firstElem))
                {
                    Console.WriteLine($"{i} rectangle (X:{arr[i].side} the same as first.");
                }
            }
            Console.ReadLine();
        }
    }
}
