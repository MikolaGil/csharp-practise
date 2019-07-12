using System;

namespace C_Types
{
    class Program
    {
        static void Main(string[] args)
        {
            //Implicit conversions
            byte a = 1;
            long a1 = a;

            int b = 10;
            decimal b1 = b;

            float c = 1000000000;
            double c1 = c;

            //Explicit conversions
            int d;
            double d1 = 3.14;
            d = (int)d1;

            sbyte e;
            double e1 = 22.222;
            e = Convert.ToSByte(e1);

            short f;
            long f1 = 45454545454545;
            f = (short)f1;

            //Packing
            byte z = 2;
            object obj = z;

            //Unpacking
            byte x = (byte)obj;

            Console.WriteLine();
            Console.Read();
        }
    }
}
