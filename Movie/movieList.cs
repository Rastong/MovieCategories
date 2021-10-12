using System;
using System.Collections.Generic;

namespace Movie
{
    class movieList
    {
        private List<MovieItem> MovieNames;

        public movieList()
        {
            MovieNames = new List<MovieItem>()
            {
                new MovieItem("stampede","animated"),
                new MovieItem("the notebook","drama"),
                new MovieItem("venom","scifi"),
                new MovieItem("rio","animated"),
                new MovieItem("guilty","drama"),
                new MovieItem("chucky","horror"),
                new MovieItem("black widow","scifi"),
                new MovieItem("dune","drama"),
                new MovieItem("insidious","horror"),
                new MovieItem("star wars","scifi")
            };
        }

        public string getCategory()
        {
            while (true)
            {
                Console.WriteLine("horror, scifi, drama, animated.");
                Console.WriteLine("What category are you interested in?");
                string input = Console.ReadLine().ToLower();
                if (input == "horror" || input == "scifi" || input == "drama" || input == "animated")
                {
                    return input;
                }
                else
                {
                    Console.WriteLine("Not a valid option, please try again.");
                }
            }
        }
        public void getMovieGenre(string genre)
        {
            foreach (MovieItem i in MovieNames)
            {
                if (i.category == genre)
                {
                    Console.WriteLine($"{i.name} : {i.category}");
                }
            }
        }
    }
}
