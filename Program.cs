﻿using System;
using System.Collections.Generic;

namespace MyFlixProgram
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("MYFLIX");
            Console.WriteLine();
            Console.WriteLine("Welcome to Myflix!");
            Console.WriteLine("Profile A.");
            Console.WriteLine("Profile B.");
            Console.WriteLine("Profile C.");
            Console.WriteLine("Profile D.");
            Console.WriteLine("Please enter your profile number:");
            Console.WriteLine();

            string? profileInput = Console.ReadLine();

            while (profileInput != "A" && profileInput != "B" && profileInput != "C" && profileInput != "D")
            {
                Console.WriteLine("Invalid profile. Please enter again.");
                profileInput = Console.ReadLine();
                Console.WriteLine();
            }

            Console.WriteLine("Welcome to profile " + profileInput + "!");
            Console.WriteLine("");
            DisplayGenres();
            
            string? genreInput = Console.ReadLine();
            Console.WriteLine();

            switch (genreInput)
            {
                case "1":
                    DisplayMovies("ROMANCE MOVIES", MovieLibrary.GetMoviesByGenre("Romance"));
                    break;

                case "2":
                    DisplayMovies("ACTION MOVIES", MovieLibrary.GetMoviesByGenre("Action"));
                    break;

                case "3":
                    DisplayMovies("HORROR MOVIES", MovieLibrary.GetMoviesByGenre("Horror"));
                    break;

                case "4":
                    DisplayMovies("SCIENCE FICTION MOVIES", MovieLibrary.GetMoviesByGenre("Science Fiction"));
                    break;

                default:
                    Console.WriteLine();
                    Console.WriteLine("Invalid input. Please try again.");
                    break;
            }
        }

        static void DisplayGenres()
        {
            Console.WriteLine("MOVIE GENRES:");
            Console.WriteLine("1. Romance");
            Console.WriteLine("2. Action");
            Console.WriteLine("3. Horror");
            Console.WriteLine("4. Science Fiction");
            Console.WriteLine();
            Console.WriteLine("Select your chosen movie genre:");
        }

        static void DisplayMovies(string genre, List<Movie> movies)
        {
            Console.WriteLine(genre + ":");
            for (int i = 0; i < movies.Count; i++)
            {
                Console.WriteLine((i + 1) + ". " + movies[i].Title);
            }
            Console.WriteLine("0. Return to Main Menu");
            Console.WriteLine();
            Console.WriteLine("Choose a movie: ");

            string? movieInput;
            movieInput = Console.ReadLine();
            Console.WriteLine();

            while (movieInput != "0")
            {
                int movieIndex;
                if (int.TryParse(movieInput, out movieIndex) && movieIndex >= 1 && movieIndex <= movies.Count)
                {
                    TitleAndDetails(movies[movieIndex - 1].Title, movies[movieIndex - 1].Casts, movies[movieIndex - 1].Details);
                    Console.WriteLine();
                    Console.WriteLine("Loading...");
                    Console.WriteLine();
                    Console.WriteLine("Enjoy watching!");
                    Console.WriteLine();
                    return;
                }
                else
                {
                    Console.WriteLine("Invalid choice. Please try again");
                    Console.WriteLine();
                }
            }
        }

        static void TitleAndDetails(string movieTitle, List<string> casts, MovieDetails details)
        {
            Console.WriteLine("Title: " + movieTitle);
            Console.WriteLine();
            Console.WriteLine("Casts: ");
            foreach (var cast in casts)
            {
                Console.WriteLine("- " + cast);
            }
            Console.WriteLine();
            Console.WriteLine("Duration: " + details.Duration.TotalMinutes + " minutes");
            Console.WriteLine();
            Console.WriteLine("Director: " + details.Director);
        }
    }
}
