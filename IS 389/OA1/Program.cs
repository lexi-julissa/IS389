//Number guesser game
//easy medium hard difficulty
//option to view past guesses

using System.Runtime.CompilerServices;

Console.WriteLine("You are playing the Number Guesser Game!");
Console.WriteLine("Please enter your name:");
string uName = Console.ReadLine();

Console.WriteLine("\nWelcome {0}!",uName);
Console.WriteLine("{0}, which difficulty would you like to play on?",uName);
Console.WriteLine("Easy (1)  Medium (2)  Hard (3)  Extreme Difficulty (4)");
int difficulty;
while (!int.TryParse(Console.ReadLine(), out difficulty) || difficulty < 1 || difficulty > 4)//makes sure a difficulty is selected
{
    Console.WriteLine("Invalid input. Please enter 1 for Easy, 2 for Medium, 3 for Hard, or 4 for Extreme.");
}


int maxNum = 0;

if (difficulty == 1)
    maxNum = 10;
if (difficulty == 2)
    maxNum = 50;
if (difficulty == 3)
    maxNum = 100;
if (difficulty == 4)
    maxNum = 1000;

int uTotalAttempts = 5;

Console.WriteLine("\nThe default number of attempts is 5.");
Console.WriteLine("Would you like to change that number?  Yes (1)  No (2)");

if (Convert.ToInt32(Console.ReadLine()) == 1)
    {
        Console.WriteLine("How many attempts would you like?");
        while (!int.TryParse(Console.ReadLine(), out uTotalAttempts) || uTotalAttempts <= 0)//ensures attempts is greater than 0
        {
            Console.WriteLine("Please enter a valid number of attempts greater than 0.");
        }   

    }

Console.WriteLine("\nLets get started! Good Luck {0}!",uName);

Random r = new Random();
int answer = r.Next(1, maxNum+1);

Dictionary <string, string> uHistory = new Dictionary<string, string>();

int uAttempts = uTotalAttempts;

for(int i = 1; i < uTotalAttempts+1; i++)
{
    
    Console.WriteLine("\nAttempts Remaining: {0}", uAttempts);
    Console.WriteLine("Guess the number 1-{0}",maxNum);
    int uGuess;
    while (!int.TryParse(Console.ReadLine(), out uGuess) || uGuess < 1 || uGuess > maxNum)//checks to make sure a vlid number is entered
    {
        Console.WriteLine("Invalid guess. Please enter a number between 1 and {0}.", maxNum);
    }
    
    
    string hint = "";

    if (uGuess < answer)
        hint = "Too Low!";
    else if (uGuess > answer)
        hint = "Too High!";
    else if (uGuess == answer)
    {
        Console.WriteLine("\nYou guessed {0}! Correct! Good Job!",uGuess);
        break;
    }

    Console.WriteLine("\nYou guessed {0}! {1}",uGuess, hint);

    uHistory[$"Guess #{i}: {uGuess}"] = hint;

    
    uAttempts--;

    if (uAttempts > 0) //only loops if player has at least 1 attempt left
    {
        Console.WriteLine("\nContinue Playing (1)  View Guess History (2) "); 

        if (Convert.ToInt32(Console.ReadLine()) == 2)
        {
            Console.WriteLine("\nGuess History:");
            foreach(KeyValuePair<string, string> KVP in uHistory)
            {
                Console.WriteLine(" {0} - {1}", KVP.Key, KVP.Value);
            }
            // Return to guessing after viewing history
            Console.WriteLine("\nPlease make your next guess:");
        }

    }
    if (uAttempts==0)
    {
        Console.WriteLine("\nOh no! You have no more attempts left! GAME OVER :(");
        Console.WriteLine("The correct number was {0}!", answer);
    }
    
}

Console.WriteLine("\nThank you for playing {0}!",uName);
