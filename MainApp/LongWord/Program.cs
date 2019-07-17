using System;

namespace LongWord
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter the text: ");
            string text = Console.ReadLine();

            string[] arrText = text.Split(' ');

            string word = LongestWord(arrText);
            string swapWords = ChangeWordPlace(arrText);
            //Console.WriteLine($"Longest word: {word}");
            Console.WriteLine($"Swap longest and shortest word: {swapWords}");
            
            Console.ReadLine();
        }

        static string LongestWord(string[] textArr)
        {
            string longWord = string.Empty;
            int length = 0;

            for (int i = 0; i < textArr.Length; i++)
            {
                if (textArr[i].Length > length)
                {
                    length = textArr[i].Length;
                    longWord = new string(textArr[i]);
                }
            }
            return longWord;
        }
        
        
        static string ChangeWordPlace(string[] textArr)
        {
            string longWord = string.Empty, shorWord = string.Empty, phrase = string.Empty;
            int longWordIndex = 0, shorWordIndex = 0;
            string[] newStringArr = textArr;

            for (int i = 0; i < textArr.Length; i++)
            {
                if (textArr[i].Length > longWord.Length)
                {
                    longWord = textArr[i];
                    longWordIndex = i;
                }
            }

            shorWord = longWord;

            for (int i = 0; i < textArr.Length; i++)
            {
                if (textArr[i].Length < shorWord.Length)
                {
                    shorWord = textArr[i];
                    shorWordIndex = i;
                }
            }

            newStringArr[longWordIndex] = shorWord;
            newStringArr[shorWordIndex] = longWord;

            phrase = string.Join(' ', newStringArr);
            return phrase;
        }
    }
}
