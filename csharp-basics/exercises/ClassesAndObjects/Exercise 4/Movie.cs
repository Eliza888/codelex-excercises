using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercise_4
{
    internal class Movie
    {
        private string title;
        private string studio;
        private string rating;

        public Movie(string title, string studio, string rating)
        {
            this.title = title;
            this.studio = studio;
            this.rating = rating;
        }

        public Movie(string title, string studio)
        {
            this.title = title;
            this.studio = studio;
            this.rating = "PG";
        }

        public string Title
        {
            get { return title; }
        }

        public string Studio
        {
            get { return studio; }
        }

        public string Rating
        {
            get { return rating; }
        }

        public static Movie[] GetPG(Movie[] movies)
        {
            return movies.Where(movie => movie.Rating == "PG").ToArray();
        }
    }
}
