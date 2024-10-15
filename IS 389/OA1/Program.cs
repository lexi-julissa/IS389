//Number guesser game
//easy medium hard difficulty
//option to view past guesses

using System.Runtime.CompilerServices;

Console.WriteLine("You are playing the Number Guesser Game!");
Console.WriteLine("Please enter your name:");
string uName = Console.ReadLine();

Console.WriteLine("\nWelcome {0}!",uName);
Console.WriteLine("{0} which difficulty would you like to play on?",uName);
Console.WriteLine("Easy (1)  Medium (2)  Hard (3)  Extreme Difficulty (4)");
int difficulty = Convert.ToInt32(Console.ReadLine());

int maxNum = 0;

if (difficulty == 1)
    maxNum = 10;
if (difficulty == 2)
    maxNum = 50;
if (difficulty == 3)
    maxNum = 100;
if (difficulty == 4)
    maxNum = 1000;

int uAttempts = 5;

Console.WriteLine("\nThe default number of attempts is 5.");
Console.WriteLine("Would you like to change that number?  Yes (1)  No (2)");
if (Convert.ToInt32(Console.ReadLine()) == 1)
    {
        Console.WriteLine("How many attempts would you like?");
        uAttempts = Convert.ToInt32(Console.ReadLine());
    }

Console.WriteLine("\nLets get started! Good Luck {0}",uName);

Random r = new Random();
int answer = r.Next(1, maxNum+1);

Dictionary <int, string> uHistory = new Dictionary<int, string>();


for(int i = 1; i < uAttempts+1; i++)
{
    Console.WriteLine("\nGuess the number 1-{0}",maxNum);
    int uGuess = Convert.ToInt16(Console.ReadLine());
    Console.WriteLine("Attempts Remaing: {0}", uAttempts);
    
    string hint = "";

    if (uGuess < answer)
        hint = "Too Low!";
    else if (uGuess > answer)
        hint = "Too High!";
    else if (uGuess == answer)
    {
        Console.WriteLine("You guessed {0}! Correct! Good Job!",uGuess);
        hint = "Correct!";
        i = uAttempts+1;
    }

    Console.WriteLine("You guessed {0}! {1}",uGuess, hint);

    uHistory[uGuess] = hint;
        
    Console.WriteLine("\nContinue Playing (1)  View Guess History (2) "); 
    if (Convert.ToInt32(Console.ReadLine()) == 2)  
    {
        foreach(KeyValuePair<int,string> KVP in uHistory)
        {
            Console.WriteLine("\n {0}: {1}",KVP.Key, KVP.Value);
        }
    }
    uAttempts--;
}

Console.WriteLine("Thank you for playing {0}!",uName);
