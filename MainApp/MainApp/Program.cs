using System;

namespace MainApp
{
    class Program
    {
        static void Main(string[] args)
        {
            short intForBoxing = 2;
            object obj = intForBoxing;

            SByte xx = Convert.ToSByte(obj);
            Console.WriteLine(xx.GetType());
            Console.ReadLine();
        }
    }
}
