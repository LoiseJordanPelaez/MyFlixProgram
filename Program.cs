

using System;
class Program
{
    static void Main ()
  {
      System.Console.WriteLine ("MYFLIX");
      System.Console.WriteLine ();
      System.Console.WriteLine ("Welcome to Myflix!");
      System.Console.WriteLine ("Profile A.");
      System.Console.WriteLine ("Profile B.");
      System.Console.WriteLine ("Profile C.");
      System.Console.WriteLine ("Profile D.");
      System.Console.WriteLine ("Please enter your profile number:");
      System.Console.WriteLine ();

      string profileInput = Console.ReadLine();

    string genreInput;

    while (profileInput != "A")
    {
      System.Console.WriteLine("Invalid profile. Please enter again.");
      profileInput = Console.ReadLine();
      System.Console.WriteLine();

    }
    
    {
      System.Console.WriteLine("Welcome to profile A!");
      System.Console.WriteLine("");
      System.Console.WriteLine("MOVIE GENRES:");
      System.Console.WriteLine("1. Romance");
      System.Console.WriteLine("2. Action");
      System.Console.WriteLine("3. Horror");
      System.Console.WriteLine("4. Science Fiction");
      System.Console.WriteLine();
      
      System.Console.WriteLine("Select your chosen movie genre: ");
      genreInput = Console.ReadLine();
      System.Console.WriteLine("");

    }

    switch (genreInput)
    {
        case "1":
        {
        System.Console.WriteLine("ROMANCE MOVIES: ");
        System.Console.WriteLine("1. Titanic");
        System.Console.WriteLine("2. Twilight");
        System.Console.WriteLine("3. Ghosted");
        System.Console.WriteLine("4. 13 Going on 30");
        System.Console.WriteLine("5. Return to Main Menu");
        System.Console.WriteLine();

            string romanceInput;
            romanceInput = Console.ReadLine();
            System.Console.WriteLine();
        
        while (romanceInput == "5")
        {
          System.Console.WriteLine("MOVIE GENRES:");
          System.Console.WriteLine("1. Romance");
          System.Console.WriteLine("2. Action");
          System.Console.WriteLine("3. Horror");
          System.Console.WriteLine("4. Science Fiction");
          System.Console.WriteLine();
      
          System.Console.WriteLine("Select your chosen movie genre: ");
          genreInput = Console.ReadLine();
          System.Console.WriteLine("");
          break;
        }
        if (romanceInput == "1" || romanceInput == "2" || romanceInput == "3" || romanceInput == "4")
        {
          System.Console.WriteLine();
          System.Console.WriteLine("Loading...");
          System.Console.WriteLine("Enjoy watching!");
          System.Console.WriteLine();
          break;
        }
        else
        {
          System.Console.WriteLine("Invalid choice. Please try again");
          System.Console.WriteLine();
          System.Console.WriteLine("ROMANCE MOVIES: ");
          System.Console.WriteLine("1. Titanic");
          System.Console.WriteLine("2. Twilight");
          System.Console.WriteLine("3. Ghosted");
          System.Console.WriteLine("4. 13 Going on 30");
          System.Console.WriteLine("5. Return to Main Menu");
          System.Console.WriteLine();
        }
    
      break;
    }
        case "2":
        {
            System.Console.WriteLine("ACTION MOVIES: ");
            System.Console.WriteLine("1. Avengers: End Game");
            System.Console.WriteLine("2. Justice League");
            System.Console.WriteLine("3. Fast and Furious X");
            System.Console.WriteLine("4. Uncharted");
            System.Console.WriteLine("5. Return to Main Menu");
            System.Console.WriteLine();

            string actionInput;
            actionInput = Console.ReadLine();
            System.Console.WriteLine();

            while (actionInput == "5")
        {
          System.Console.WriteLine("MOVIE GENRES:");
          System.Console.WriteLine("1. Romance");
          System.Console.WriteLine("2. Action");
          System.Console.WriteLine("3. Horror");
          System.Console.WriteLine("4. Science Fiction");
          System.Console.WriteLine();
      
          System.Console.WriteLine("Select your chosen movie genre: ");
          genreInput = Console.ReadLine();
          System.Console.WriteLine("");
          break;
        }
        if (actionInput == "1" || actionInput == "2" || actionInput == "3" || actionInput == "4")
        {
          System.Console.WriteLine();
          System.Console.WriteLine("Loading...");
          System.Console.WriteLine("Enjoy watching!");
          System.Console.WriteLine();
          break;
        }
        else
        {
          System.Console.WriteLine("Invalid choice. Please try again");
          System.Console.WriteLine();
          System.Console.WriteLine("ACTION MOVIES: ");
          System.Console.WriteLine("1. Avengers: End Game");
          System.Console.WriteLine("2. Justice League");
          System.Console.WriteLine("3. Fast and Furious X");
          System.Console.WriteLine("4. Uncharted");
          System.Console.WriteLine("5. Return to Main Menu");
          System.Console.WriteLine();
        }
            break;
        }
        case "3":
        {
            System.Console.WriteLine("HORROR MOVIES: ");
            System.Console.WriteLine("1. Insidious");
            System.Console.WriteLine("2. Conjuring");
            System.Console.WriteLine("3. The Exorcist");
            System.Console.WriteLine("4. The Texas Chainsaw Massacre");
            System.Console.WriteLine("5. Return to Main Menu");
            System.Console.WriteLine();

            string horrorInput;
            horrorInput = Console.ReadLine();
            System.Console.WriteLine();
      while (horrorInput == "5")
        {
          System.Console.WriteLine("MOVIE GENRES:");
          System.Console.WriteLine("1. Romance");
          System.Console.WriteLine("2. Action");
          System.Console.WriteLine("3. Horror");
          System.Console.WriteLine("4. Science Fiction");
          System.Console.WriteLine();
      
          System.Console.WriteLine("Select your chosen movie genre: ");
          genreInput = Console.ReadLine();
          System.Console.WriteLine("");
          break;
        }
        if (horrorInput == "1" || horrorInput == "2" || horrorInput == "3" || horrorInput == "4")
        {
          System.Console.WriteLine();
          System.Console.WriteLine("Loading...");
          System.Console.WriteLine("Enjoy watching!");
          System.Console.WriteLine();
          break;
        }
        else
        {
          System.Console.WriteLine("Invalid choice. Please try again");
          System.Console.WriteLine();
          System.Console.WriteLine("HORROR MOVIES: ");
          System.Console.WriteLine("1. Insidious");
          System.Console.WriteLine("2. Conjuring");
          System.Console.WriteLine("3. The Exorcist");
          System.Console.WriteLine("4. The Texas Chainsaw Massacre");
          System.Console.WriteLine("5. Return to Main Menu");
          System.Console.WriteLine();
        }
            break;
        }
        case "4":
        {
            System.Console.WriteLine("SCIENCE FICTION MOVIES: ");
            System.Console.WriteLine("1. Pixels");
            System.Console.WriteLine("2. Power Rangers");
            System.Console.WriteLine("3. Spiderman: No Way Home");
            System.Console.WriteLine("4. The Adam Project");
            System.Console.WriteLine("5. Return to Main Menu");
            System.Console.WriteLine();

            string scifiInput;
            scifiInput = Console.ReadLine();
            System.Console.WriteLine();
        while (scifiInput == "5")
        {
          System.Console.WriteLine("MOVIE GENRES:");
          System.Console.WriteLine("1. Romance");
          System.Console.WriteLine("2. Action");
          System.Console.WriteLine("3. Horror");
          System.Console.WriteLine("4. Science Fiction");
          System.Console.WriteLine();
      
          System.Console.WriteLine("Select your chosen movie genre: ");
          genreInput = Console.ReadLine();
          System.Console.WriteLine("");
          break;
        }
        if (scifiInput == "1" || scifiInput == "2" || scifiInput == "3" || scifiInput == "4")
        {
          System.Console.WriteLine();
          System.Console.WriteLine("Loading...");
          System.Console.WriteLine("Enjoy watching!");
          System.Console.WriteLine();
          break;
        }
        else
        {
          System.Console.WriteLine("Invalid choice. Please try again");
          System.Console.WriteLine();
          System.Console.WriteLine("SCIENCE FICTION MOVIES: ");
          System.Console.WriteLine("1. Pixels");
          System.Console.WriteLine("2. Power Rangers");
          System.Console.WriteLine("3. Spiderman: No Way Home");
          System.Console.WriteLine("4. The Adam Project");
          System.Console.WriteLine("5. Return to Main Menu");
          System.Console.WriteLine();
        }
            break;
        }
        default:  
            System.Console.WriteLine();
            System.Console.WriteLine("Invalid input. Please try again.");
            break;
    }
  }
}
