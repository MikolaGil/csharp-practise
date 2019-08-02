using System;
using System.Collections.Generic;
using System.Text;

namespace Song
{
    class Song
    {
        string _songName;
        public string SongName{ get; set; }
        int _minutes;
        public int Minutes { get; set; }
        string _author;
        public string Author { get; set; }
        int _year;
        public int Year {
            get {
                return _year;
            }
            set
            {
                int currentYear = DateTime.Now.Year;
                if (value > currentYear)
                {
                    _year = currentYear;
                }
            }
        }

        enum genre
        {
            classic,
            pop,
            rock,
            punk
        }
        public object GetSongData()
        {
            Song song = new Song();
            var values = Enum.GetValues(typeof(genre));
            string genre;

            Console.WriteLine("Enter the song name:");
            song.SongName = Console.ReadLine();
            Console.WriteLine("Enter the song duration:");
            song.Minutes = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Enter the song author:");
            song.Author = Console.ReadLine();
            Console.WriteLine("Enter the year of publishing:");
            song.Year = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Choose one of the genre:");
            foreach (genre foo in Enum.GetValues(typeof(genre)))
            {
                Console.WriteLine(foo);
            }
            genre = Console.ReadLine();

            var songData = new { song.SongName, song.Minutes, song.Author, song.Year, genre };
            return songData;
        }
        
    }
}
