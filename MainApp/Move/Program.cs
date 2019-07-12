using System;

namespace Move
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Choose direction(You can use W, A, S, D buttons):");
            GetMove();

            void GetMove()
            {
                string action = Console.ReadLine().ToUpper();
                Moving(action);
            }

            void Moving(string direction)
            {
                switch (direction)
                {
                    case "W":
                        Console.WriteLine("Go UP");
                        break;
                    case "A":
                        Console.WriteLine("Go Left");
                        break;
                    case "S":
                        Console.WriteLine("Go Down");
                        break;
                    case "D":
                        Console.WriteLine("Go Right");
                        break;
                    default:
                        Console.WriteLine("Wrong direction!");
                        break;
                }

                GetMove();
            }
        }
    }
}
