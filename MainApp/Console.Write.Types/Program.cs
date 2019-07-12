using System;

namespace Task2
{
    class Program
    {
        static void Main(string[] args)
        {
            bool a = true;
            System.Boolean a1 = false;
            System.Type[] a2 = { a.GetType(), a1.GetType() };
            foreach (var item in a2)
                Console.Write(item.ToString() + "\n");

            byte b = 10;
            System.Byte b1 = 11;
            System.Type[] b2 = { b.GetType(), b1.GetType() };
            foreach (var item in b2)
                Console.Write(item.ToString() + "\n");

            sbyte c = 22;
            System.SByte c1 = 23;
            System.Type[] c2 = { c.GetType(), c1.GetType() };
            foreach (var item in c2)
                Console.Write(item.ToString() + "\n");

            short d = -33;
            System.Int16 d1 = -34;
            System.Type[] d2 = { d.GetType(), d1.GetType() };
            foreach (var item in d2)
                Console.Write(item.ToString() + "\n");

            ushort e = 33;
            System.UInt16 e1 = 34;
            System.Type[] e2 = { e.GetType(), e1.GetType() };
            foreach (var item in e2)
                Console.Write(item.ToString() + "\n");

            int f = 44;
            System.Int32 f1 = 45;
            System.Type[] f2 = { f.GetType(), f1.GetType() };
            foreach (var item in f2)
                Console.Write(item.ToString() + "\n");

            uint g = 55;
            System.UInt32 g1 = 56;
            System.Type[] g2 = { g.GetType(), g1.GetType() };
            foreach (var item in g2)
                Console.Write(item.ToString() + "\n");

            long h = -555;
            System.Int64 h1 = -556;
            System.Type[] h2 = { h.GetType(), h1.GetType() };
            foreach (var item in h2)
                Console.Write(item.ToString() + "\n");

            ulong i = 555;
            System.UInt64 i1 = 556;
            System.Type[] i2 = { i.GetType(), i1.GetType() };
            foreach (var item in i2)
                Console.Write(item.ToString() + "\n");

            float j = 666;
            System.Single j1 = 667;
            System.Type[] j2 = { j.GetType(), j1.GetType() };
            foreach (var item in j2)
                Console.Write(item.ToString() + "\n");

            double k = 777;
            System.Double k1 = 778;
            System.Type[] k2 = { k.GetType(), k1.GetType() };
            foreach (var item in k2)
                Console.Write(item.ToString() + "\n");

            decimal l = 888;
            System.Decimal l1 = 889;
            System.Type[] l2 = { l.GetType(), l1.GetType() };
            foreach (var item in l2)
                Console.Write(item.ToString() + "\n");

            char m = 'a';
            System.Char m1 = 'b';
            System.Type[] m2 = { m.GetType(), m1.GetType() };
            foreach (var item in m2)
                Console.Write(item.ToString() + "\n");

            string n = "Hello";
            System.String n1 = "Bye";
            System.Type[] n2 = { n.GetType(), n1.GetType() };
            foreach (var item in n2)
                Console.Write(item.ToString() + "\n");

            Console.ReadLine();
        }
    }
}
