using System;

// Namespace
namespace NumberGuesser
{
    // Main Class
    class Program
    {
        // Entry Point Method
        // void - return type
        // static - refers to the function itself.
        static void Main(string[] args)
        {
            // Run getAppInfo function to get application details.
            GetAppInfo();

            // Ask for user's name.
            GreetUser();

            // Start Game
            PlayGame();

           
        }
        // Get and display application details
        static void GetAppInfo()
        {
            // Set app variables
            string appName = "Number Guesser";
            string appVersion = "1.0.0";
            string appAuthor = "Tom Williams";

            // Change text color
            Console.ForegroundColor = ConsoleColor.Green;

            // Write out application info
            Console.WriteLine("{0}: Version {1} by {2}", appName, appVersion, appAuthor);

            // Reset text color
            Console.ResetColor();
        }
        // Ask user's name and greets them.
        static void GreetUser()
        {
            // Ask for user's name
            Console.WriteLine("What is your name?");

            // Get user input
            string inputName = Console.ReadLine();

            Console.WriteLine("Hello {0}, let's play a game...", inputName);
        }
        
        static void PlayGame()
        {
            while (true)
            {
                // Create a new Random object
                Random random = new Random();

                // Init correct number
                int correctNumber = random.Next(1, 10);

                // Init guess variable
                int guess = 0;

                // Ask user for a number
                Console.WriteLine("Guess a number between 1 and 10");

                // While guess is not correct
                while (guess != correctNumber)
                {
                    // Get users input
                    string input = Console.ReadLine();

                    // Make sure its a number entered
                    if (!int.TryParse(input, out guess))
                    {
                        // Print error message
                        PrintColorMessage(ConsoleColor.Red, "Please enter a number!");

                        //Keep going
                        continue;
                    }

                    // Cast to int and put in guess variable
                    guess = Int32.Parse(input);

                    // Match guess to correct Number
                    if (guess < correctNumber)
                    {
                        // Print error message
                        PrintColorMessage(ConsoleColor.Red, "Incorrect guess");
                        PrintColorMessage(ConsoleColor.Yellow, "Guess higher...");
                  

                    }
                    else if (guess > correctNumber)
                    {
                        PrintColorMessage(ConsoleColor.Red, "Incorrect guess");
                        PrintColorMessage(ConsoleColor.Yellow, "Guess lower...");
                       
                    }
                    else
                    {
                        // Output success message
                        PrintColorMessage(ConsoleColor.Yellow, "You are CORRECT!!! You guessed the number.");

                        // Ask to play again
                        Console.WriteLine("Play Again? [Y or N]");

                        // Get answer to play again
                        string answer = Console.ReadLine().ToUpper();

                        if (answer == "Y")
                        {
                            continue;
                        }
                        else if (answer == "N")
                        {
                            return;
                        }
                        else
                        {
                            return;
                        }
                    }
                }
            }

        }
        // Print color message
        static void PrintColorMessage(ConsoleColor color, string message)
        {
            // Change text color
            Console.ForegroundColor = color;

            // Tell user they didn't enter a number
            Console.WriteLine(message);

            // Reset text color
            Console.ResetColor();
        }
    }
}
