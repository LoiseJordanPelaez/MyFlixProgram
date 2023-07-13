using System;

namespace MyFlixProgram
{
    public class MovieDetails
    {
        public TimeSpan Duration {get; set;}
        public string Director {get; set;}
        public MovieDetails(TimeSpan duration, string director)
        {
            Duration = duration;
            Director = director;
        }
    }
}