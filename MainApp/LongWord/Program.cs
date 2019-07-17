using System;
using System.Text.RegularExpressions;


namespace LongWord
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter the text: ");
            string text = Console.ReadLine();

            string[] arrText = text.Split(' ');

            string removeWord = removeLongestWord(arrText);
            string swapWords = ChangeWordIndex(arrText);
            int[] charactersCount = countCharacters(text);

            Console.WriteLine($"Text without longest word: {removeWord}");
            Console.WriteLine($"Swap longest and shortest words: {swapWords}");
            Console.WriteLine($"Number of characters: {charactersCount[0]}");
            Console.WriteLine($"Number of symbols: {charactersCount[1]}");
            SortString(arrText);

            Console.ReadLine();
        }

        static string removeLongestWord(string[] textArr)
        {
            int longWordIndex = 0;
            int length = 0;

            for (int i = 0; i < textArr.Length; i++)
            {
                if (textArr[i].Length > length)
                {
                    length = textArr[i].Length;
                    longWordIndex = i;
                }
            }

            textArr[longWordIndex] = "";

            string result = string.Join(' ', textArr);
            return result;
        }
        
        static string ChangeWordIndex(string[] textArr)
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

        static int[] countCharacters(string text)
        {
            int[] charsAmount = new int[2];
            Regex regChars = new Regex(@"\w");
            Regex regSymbols = new Regex(@"\W");

            MatchCollection charMatches = regChars.Matches(text);
            MatchCollection symbolMatches = regSymbols.Matches(text);

            charsAmount[0] = charMatches.Count;
            charsAmount[1] = symbolMatches.Count;
            return charsAmount;
        }

        static void SortString(string[] text)
        {
            string temp = string.Empty;

            for (int write = 0; write < text.Length; write++)
            {
                for (int sort = 0; sort < text.Length - 1; sort++)
                {
                    if (text[sort].Length > text[sort + 1].Length)
                    {
                        temp = text[sort + 1];
                        text[sort + 1] = text[sort];
                        text[sort] = temp;
                    }
                }
            }

            for (int i = 0; i < text.Length; i++)
                Console.WriteLine(text[i]);
        }
    }
}
