using System;

namespace Movie
{
    class Program
    {
        static void Main(string[] args)
        {
            movieList myMovieList = new movieList();
            bool runProgram = true;
            while (runProgram)
            {
                string genre = myMovieList.getCategory();

                myMovieList.getMovieGenre(genre);

                runProgram = Validator.Validator.getContinue();            
            }

        }
        
        
    }
}
