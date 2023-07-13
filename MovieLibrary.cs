using System;
using System.Collections.Generic;

namespace MyFlixProgram
{
    class MovieLibrary
    {
        public static List<Movie> GetMovies()
        {
            return new List<Movie>
            {
                new Movie("Romance", "Titanic", new List<string> { "Leonardo DiCaprio", "Kate Winslet" }, new MovieDetails(TimeSpan.FromMinutes(194), "James Cameron")),
                new Movie("Romance", "Twilight", new List<string> { "Kristen Stewart", "Robert Pattinson" }, new MovieDetails(TimeSpan.FromMinutes(122), "Catherine Hardwicke")),
                new Movie("Romance", "Ghosted", new List<string> { "Ryan Reynolds", "Emma Stone" }, new MovieDetails(TimeSpan.FromMinutes(106), "Andy Fickman")),
                new Movie("Romance", "13 Going on 30", new List<string> { "Jennifer Garner", "Mark Ruffalo" }, new MovieDetails(TimeSpan.FromMinutes(98), "Gary Winick")),
                new Movie("Action", "Avengers: Endgame", new List<string> { "Robert Downey Jr.", "Chris Evans", "Scarlett Johansson" }, new MovieDetails(TimeSpan.FromMinutes(181), "Anthony Russo, Joe Russo")),
                new Movie("Action", "Justice League", new List<string> { "Ben Affleck", "Gal Gadot", "Jason Momoa" }, new MovieDetails(TimeSpan.FromMinutes(120), "Zack Snyder")),
                new Movie("Action", "Fast and Furious X", new List<string> { "Vin Diesel", "Michelle Rodriguez", "Dwayne Johnson" }, new MovieDetails(TimeSpan.FromMinutes(145), "Justin Lin")),
                new Movie("Action", "Uncharted", new List<string> { "Tom Holland", "Mark Wahlberg" }, new MovieDetails(TimeSpan.FromMinutes(112), "Ruben Fleischer")),
                new Movie("Horror", "Insidious", new List<string> { "Patrick Wilson", "Rose Byrne" }, new MovieDetails(TimeSpan.FromMinutes(103), "James Wan")),
                new Movie("Horror", "The Conjuring", new List<string> { "Vera Farmiga", "Patrick Wilson" }, new MovieDetails(TimeSpan.FromMinutes(112), "James Wan")),
                new Movie("Horror", "The Exorcist", new List<string> { "Ellen Burstyn", "Max von Sydow" }, new MovieDetails(TimeSpan.FromMinutes(122), "William Friedkin")),
                new Movie("Horror", "The Texas Chainsaw Massacre", new List<string> { "Jessica Biel", "Jonathan Tucker" }, new MovieDetails(TimeSpan.FromMinutes(98), "Marcus Nispel")),
                new Movie("Science Fiction", "Pixels", new List<string> { "Adam Sandler", "Kevin James", "Michelle Monaghan" }, new MovieDetails(TimeSpan.FromMinutes(105), "Chris Columbus")),
                new Movie("Science Fiction", "Power Rangers", new List<string> { "Dacre Montgomery", "Naomi Scott", "RJ Cyler" }, new MovieDetails(TimeSpan.FromMinutes(124), "Dean Israelite")),
                new Movie("Science Fiction", "Spiderman: No Way Home", new List<string> { "Tom Holland", "Zendaya", "Alfred Molina" }, new MovieDetails(TimeSpan.FromMinutes(148), "Jon Watts")),
                new Movie("Science Fiction", "Ready Player One", new List<string> { "Letitia Wright", "Daniel Eghan", "Antionio Mattera" }, new MovieDetails(TimeSpan.FromMinutes(140), "Steven Spielberg")),
                new Movie("Science Fiction", "The Adam Project", new List<string> { "Ryan Reynolds", "Jennifer Garner", "Zoe Saldana" }, new MovieDetails(TimeSpan.FromMinutes(117), "Shawn Levy")),
            };
        }

        public static List<Movie> GetMoviesByGenre(string genre)
        {
            List<Movie> movies = GetMovies();
            List<Movie> filteredMovies = new List<Movie>();

            foreach (var movie in movies)
            {
                if (movie.Genre.Equals(genre, StringComparison.OrdinalIgnoreCase))
                {
                    filteredMovies.Add(movie);
                }
            }

            return filteredMovies;
        }
    }
}
