using System;
using System.Collections;

namespace Alphabet
{
    class Program
    {
        static void Main(string[] args)
        {
            ArrayList arr = new ArrayList();
            int firstLetter = 0x41;
            int lastLetter = 0x59;

            for(int i = lastLetter; i >= firstLetter; i--)
            {
                string character = i.ToString("X");
                arr.Add(character);
            }

            foreach (string elem in arr)
            {
                string converted = ((char)Convert.ToInt16(elem, 16)).ToString();
                Console.WriteLine(converted);
            }

            Console.ReadLine();
        }
    }
}
