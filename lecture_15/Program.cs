using System;
using System.Linq;

namespace lecture_15
{
    static class Program
    {
        static void Main(string[] args)
        {
            string test = "Hello World";
            test.FirstFiveLetters(test);
        }
        public static string FirstFiveLetters(this String str, string text)
        {
            string result = new string(text.Take(5).ToArray());
            return result;
        }
        
    }
    
}
