using System;
using System.Collections.Generic;

namespace MyFlixProgram
{
    public class Movie
    {
        public string Genre {get; set;}
        public string Title {get; set;}
        public List<string> Casts {get; set;}
        public MovieDetails Details {get; set;}

        public Movie(string genre, string title, List<string> casts, MovieDetails details)
        {
            Genre = genre;
            Title = title;
            Casts = casts;
            Details = details;
        }
    }
}