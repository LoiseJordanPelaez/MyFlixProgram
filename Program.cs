// Pelaez, Loise Jordan I. 
// BSCPE 1-1
/* A streaming service that allows people 
to watch movies on an internet-connected device. */

using System;

namespace MyFlixProgram
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("MYFLIX");
            Console.WriteLine();
            Console.WriteLine("Welcome to Myddflix!");
            Console.WriteLine("Profile A.");
            Console.WriteLine("Profile B.");
            Console.WriteLine("Profile C.");
            Console.WriteLine("Profile D.");
            Console.WriteLine("Please enter your profile number:");
            Console.WriteLine();

            string? profileInput = Console.ReadLine();

            string? genreInput;

            while (profileInput != "A" && profileInput != "B" && profileInput != "C" && profileInput != "D")
            {
                Console.WriteLine("Invalid profile. Please enter again.");
                profileInput = Console.ReadLine();
                Console.WriteLine();
            }

            Console.WriteLine("Welcome to profile " + profileInput + "!");
            Console.WriteLine("");
            DisplayGenres();

            genreInput = Console.ReadLine();
            Console.WriteLine();

            switch (genreInput)
            {
 
                case "1":
                    DisplayMovies("ROMANCE MOVIES", new string[] { "Titanic", "Twilight", "Ghosted", "13 Going on 30" }, new string[]
                    {
                        "Rose DeWitt Bukater informs the narrative of her own life aboard the Titanic, 8-4 years later. A young Rose boards the boat with fiancé and her mother. Meanwhile, the Jack Dawson and Fabrizio De Rossi win tickets aboard the boat. Rose informs the story from the departure of Titanic to its death--on its first and last voyage--on April 15, 1912.",
                        "When Bella Swan proceeds to a little town in the Pacific Northwest to live with her father, she meets the Edward Cullen. Despite the perennial warnings of Edward, Bella can't help but love him, if a coven of blood suckers make an effort to challenge the Cullen clan, a move that ignites her life.",
                        "Salt-of-the-earth Cole falls head over heels for enigmatic Sadie — but then makes the shocking discovery that she’s a secret agent. Before they can decide on a second date, Cole and Sadie are swept away on an international adventure to save the world.",
                        "After total embarrassment at her birthday party, Jenna Rink would like to hide until she has thirty. Her wish is allowed, however as it happens that being half isn't as consistently as magnificent as she thought it would be!"
                    });
                    break;

                case "2":
                    DisplayMovies("ACTION MOVIES", new string[] { "Avengers: Endgame", "Justice League", "Fast and Furious X", "Uncharted" }, new string[]
                    {
                        "The universe Remains due to Their Mad Titan, Thanos' efforts. With the aid of allies that are remaining, the Avengers must build to undo Thanos' actions and restore order to the world once and for all.",
                        "Fuelled by his Revived faith in Humankind and inspired by Superman's selfless Action, Bruce Wayne and Diana Prince assemble a team of metahumans consisting of Barry Allen, Arthur Curry and Victor Stone to Handle the catastrophic Risk of Steppenwolf and the Parademons Who're on the hunt for Just Three Mother Boxes Around Earth.",
                        "Over many missions and against impossible odds, Dom Toretto and his family have outsmarted, out-nerved and outdriven every foe in their path. Now, they confront the most lethal opponent they've ever faced: A terrifying threat emerging from the shadows of the past who's fueled by blood revenge, and who is determined to shatter this family and destroy everything—and everyone—that Dom loves, forever.",
                        "A young street-smart, Nathan Drake and also his wisecracking partner Victor Sullivan start a dangerous search of the best treasure never found while additionally tracking hints that might cause Nathan's long-lost bro."
                    });
                    break;

                case "3":
                    DisplayMovies("HORROR MOVIES", new string[] { "Insidious", "The Conjuring", "The Exorcist", "The Texas Chainsaw Massacre" }, new string[]
                    {
                        "A family discovers that their home has been invaded by spirits after their son inexplicably falls into an infinite sleep. They learn things are far more personal than they thought Once they reach out to a professional for assistance.",
                        "Paranormal investigators Ed and Lorraine Warren work to help a family terrorized by way of a presence in their own farm house. The Warrens are trapped in the terrifying case of his or her lifetimes.",
                        "Father Gabriele Amorth, Chief Exorcist of the Vatican, investigates a young boy's terrifying possession and ends up uncovering a centuries-old conspiracy the Vatican has desperately tried to keep hidden.",
                        "After nearly 50 years of hiding, Leatherface returns to terrorize a group of optimistic young close friends who mistakenly disrupt his very carefully secured world in a remote Texas community."
                    });
                    break;

                case "4":
                    DisplayMovies("SCIENCE FICTION MOVIES", new string[] { "Pixels", "Power Rangers", "Spiderman: No Way Home", "The Adam Project" }, new string[]
                    {
                        "Game pros are recruited by the military to fight game characters that have attacked newyork.",
                        "Saban's Power Rangers follows five teens who has to become something outstanding whenever they learn that their town of Angel Grove -- and the entire world -- is still on the point to be calmed by an alien threat. Our heroes quickly detect they are the only ones who are able to save the planet. But they might need to over come their issues that are real-life and before it's too late, ring collectively since the Power Rangers to accomplish this.",
                        "Peter Parker is uncovered and no more able to separate his typical life from the high-stakes of being a super-hero. When he requests assistance from Physician Strange the risks come to be much more unsafe, forcing him to find what it truly means to be Spider-Man.",
                        "After mistakenly crash-landing in 2022, time-traveling competitor pilot Adam Reed teams up with his 12-year-old self on an objective to conserve the future."
                    });
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

        static void DisplayMovies(string genre, string[] movies, string[] synopses)
        {
            Console.WriteLine(genre + ":");
            for (int i = 0; i < movies.Length; i++)
            {
                Console.WriteLine((i + 1) + ". " + movies[i]);
            }
            Console.WriteLine("5. Return to Main Menu");
            Console.WriteLine();
            System.Console.WriteLine("Choose a movie: ");

            string? movieInput;
            movieInput = Console.ReadLine();
            Console.WriteLine();

            while (movieInput != "5")
            {
                int movieIndex;
                if (int.TryParse(movieInput, out movieIndex) && movieIndex >= 1 && movieIndex <= movies.Length)
                {
                    Console.WriteLine();
                    Console.WriteLine("Loading...");
                    System.Console.WriteLine();
                    TitleAndSynopsis(movies[movieIndex - 1], synopses[movieIndex - 1]);
                    System.Console.WriteLine();
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

        static void TitleAndSynopsis(string movieTitle, string synopsis)
        {
            Console.WriteLine("Title: " + movieTitle);
            System.Console.WriteLine();
            Console.WriteLine("Synopsis: " + synopsis);
        }
    }
}
