namespace Exercise_4
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Movie movie1 = new Movie("Casino Royale", "Eon Productions", "PG-13");
            Movie movie2 = new Movie("Glass", "Buena Vista International", "PG-13");
            Movie movie3 = new Movie("Spider-Man: Into the Spider-Verse", "Columbia Pictures", "PG");
            Movie movie4 = new Movie("The Matrix", "Warner Bros.", "R");

            Movie[] movies = { movie1, movie2, movie3, movie4 };

            Movie[] pgMovies = Movie.GetPG(movies);

            Console.WriteLine("Movies with a rating of 'PG':");
            foreach (var movie in pgMovies)
            {
                Console.WriteLine($"Title: {movie.Title}, Studio: {movie.Studio}, Rating: {movie.Rating}");
            }
        }
    }
}
