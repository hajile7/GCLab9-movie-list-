//welcome
using GCLab9__movie_database_;

Console.WriteLine("Welcome to my Movie List Application!");

//create movie objects
Movies interstellar = new Movies("Interstellar", "scifi", 2014);
Movies alien = new Movies("Alien", "scifi", 1979);
Movies et = new Movies("E.T.", "scifi", 1982);
Movies spiritedAway = new Movies("Spirited Away", "ghibli", 2001);
Movies howlsMovingCastle = new Movies("Howl's Moving Castle", "ghibli", 2004);
Movies castleInTheSky = new Movies("Castle in the Sky", "ghibli", 1986);
Movies theLabyrinth = new Movies("The Labyrinth", "fantasy", 1986);
Movies theHobbit = new Movies("The Hobbit", "fantasy", 2012);
Movies theNeverEndingStory = new Movies("The Never Ending Story", "fantasy", 1984);
Movies hereditary = new Movies("Hereditary", "horror", 2018);
Movies mother = new Movies("Mother", "horror", 2017);
Movies sinister = new Movies("Sinister", "horror", 2012);

//create movie list
List<Movies> allMovies = new List<Movies>()
{
    interstellar, alien, et, spiritedAway, howlsMovingCastle, castleInTheSky, theHobbit, theNeverEndingStory, 
    theLabyrinth, hereditary, mother, sinister
};

//create program loop
bool runProgram = true;
while (runProgram)
{

    //see what category user would like to see 
    Console.WriteLine("Which category would you like to view? Please enter its name or associated number.");
    Console.WriteLine("1: Scifi\n2: Ghibli\n3: Fantasy\n4: Horror"); //hardcoding implementation of extended since i don't plan on scaling project
    Console.Write("Your answer: ");

    //get + validate user input
    string choice = Console.ReadLine().ToLower().Trim();
    while (choice != "scifi" && choice != "ghibli" && choice != "fantasy" && choice != "horror" //added nums for menu extended
           && choice != "1" && choice != "2" && choice != "3" && choice != "4") 
    {
        Console.Write("That is an invalid selection, please try again: ");
        choice = Console.ReadLine().ToLower().Trim();
    }

    //output movie list based on selection
    List<string> temp = new List<string>(); //create a list so we can use LINQ to fulfill the alphabetical display extended
    if (choice == "scifi" || choice == "1")
    {
        foreach (Movies m in allMovies)
        {
            if (m.category == "scifi")
            {
                temp.Add($"{m.title} ({m.year})"); //get a temporary list of all movies in the chosen category along with their years using string interpolation
            }
        }
        Console.WriteLine(String.Join("\n", temp.OrderBy(x => x))); //use linq to sort the temp list and then display its results via string.join
    }
    else if (choice == "ghibli" || choice == "2")
    {
        foreach (Movies m in allMovies)
        {
            if (m.category == "ghibli")
            {
                temp.Add(string.Format("{0} ({1})", m.title, m.year)); //can also use string format
            }
        }
        Console.WriteLine(String.Join("\n", temp.OrderBy(x => x)));
    }
    else if (choice == "fantasy" || choice == "3")
    {
        foreach (Movies m in allMovies)
        {
            if (m.category == "fantasy")
            {
                temp.Add($"{m.title} ({m.year})");
            }
        }
        Console.WriteLine(String.Join("\n", temp.OrderBy(x => x)));
    }
    else //using just an else here because our prior validation should negate any bad input
    {
        foreach (Movies m in allMovies)
        {
            if (m.category == "horror")
            {
                temp.Add($"{m.title} ({m.year})");
            }
        }
        Console.WriteLine(String.Join("\n", temp.OrderBy(x => x)));
    }

    //see if user would like to go again
    while (true)
    {
        Console.WriteLine("Would you like to continue using this program? y/n");
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