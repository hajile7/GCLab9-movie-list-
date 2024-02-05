//welcome
using GCLab9__movie_database_;

Console.WriteLine("Welcome to my Movie List Application!");

//create movie objects
Movies interstellar = new Movies("Interstellar", "scifi");
Movies alien = new Movies("Alien", "scifi");
Movies et = new Movies("E.T.", "scifi");
Movies spiritedAway = new Movies("Spirited Away", "ghibli");
Movies howlsMovingCastle = new Movies("Howl's Moving Castle", "ghibli");
Movies castleInTheSky = new Movies("Castle in the Sky", "ghibli");
Movies theLabyrinth = new Movies("The Labyrinth", "fantasy");
Movies theHobbit = new Movies("The Hobbit", "fantasy");
Movies theNeverEndingStory = new Movies("The Never Ending Story", "fantasy");
Movies insidious = new Movies("Insidious", "horror");
Movies mother = new Movies("Mother", "horror");
Movies sinister = new Movies("Sinister", "horror");

//create movie list
List<Movies> allMovies = new List<Movies>()
{
    interstellar, alien, et, spiritedAway, howlsMovingCastle, castleInTheSky, theHobbit, theNeverEndingStory, 
    theLabyrinth, insidious, mother, sinister
};

//create program loop
bool runProgram = true;
while (runProgram)
{

    //see what category user would like to see 
    Console.WriteLine("Which category would you like to view? Options include: scifi, ghibli, fantasy, or horror");
    Console.Write("Your answer: ");

    //get + validate user input
    string choice = Console.ReadLine().ToLower().Trim();
    while (choice != "scifi" && choice != "ghibli" && choice != "fantasy" && choice != "horror")
    {
        Console.Write("That is an invalid selection, please try again: ");
        choice = Console.ReadLine().ToLower().Trim();
    }

    //output movie list based on selection
    if (choice == "scifi")
    {
        foreach (Movies m in allMovies)
        {
            if (m.category == "scifi")
            {
                Console.WriteLine(m.title);
            }
        }
    }
    else if (choice == "ghibli")
    {
        foreach (Movies m in allMovies)
        {
            if (m.category == "ghibli")
            {
                Console.WriteLine(m.title);
            }
        }
    }
    else if (choice == "fantasy")
    {
        foreach (Movies m in allMovies)
        {
            if (m.category == "fantasy")
            {
                Console.WriteLine(m.title);
            }
        }
    }
    else //using just an else here because our prior validation should negate any bad input
    {
        foreach (Movies m in allMovies)
        {
            if (m.category == "horror")
            {
                Console.WriteLine(m.title);
            }
        }
    }

    //see if user would like to go again
    while (true)
    {
        Console.WriteLine("Would you like to continue using this program?");
        string progChoice = Console.ReadLine().ToLower().Trim();
        if (progChoice == "y")
        {
            runProgram = true;
            break;
        }
        else if (progChoice == "n")
        {
            Console.WriteLine("Thanks for using my program. Goodbye!");
            runProgram = false;
            break;
        }
        else
        {
            Console.WriteLine("Invalid. Try Again: ");
        }
    }

}