using System;

namespace Song
{
    class Program
    {
        static void Main(string[] args)
        {
            Song song = new Song();
            Console.WriteLine(song.GetSongData());
            Console.ReadLine();
        }
    }
}
