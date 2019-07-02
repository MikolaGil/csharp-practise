using System;

namespace Task1
{
    class Program
    {
        static void Main(string[] args)
        {
            short zz = 2;
            object obj = zz;

            SByte xx = Convert.ToSByte(obj);
            Console.WriteLine(xx.GetType());
            Console.ReadLine();
        }
    }
}
