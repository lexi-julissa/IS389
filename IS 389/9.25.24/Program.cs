// //week 5 - 9.25.24

// //toLower
// Console.WriteLine("enter something:");
// string uMsg = Console.ReadLine().ToLower();
// Console.WriteLine(uMsg);

// //create a program that counted the letters and numbers 
//     //in users input
//     int letterCount = 0;
//     int numberCount = 0;
//     foreach(Char c  in uMsg)
//     {
//         if(Char.isLetter(c))
//             lettercount++;
//         if(Char.IsLetter(c))
//             numberCount++;

//     }
//     Console.WriteLine("{0} contains {1} letters and {2} numbers",uMsg, letterCount,numberCount);

// //isLetter
// Console.WriteLine(char.IsLetter('a'));//returns true or false if it has the letter

// //unicode

//in class assignment

// Random r = new Random();
// Dictionary<char, int> codeLetters = new Dictionary<char, int>();

// // Generate 5 unique code letters and initialize their counts to 0
// while (codeLetters.Count < 5)
// {
//     char uniChar = (char)r.Next(97, 123); // 'a' to 'z'
//     if (!codeLetters.ContainsKey(uniChar))
//     {
//         codeLetters.Add(uniChar, 0); // Initialize count to 0
//     }
// }

// int totalPoints = 0;

//     // Allow user to enter 5 phrases
//     for (int i = 1; i <= 5; i++)
//     {
//         Console.WriteLine("Enter phrase #{i}/5:",i);
//         string userPhrase = Console.ReadLine().ToLower();

//         // Count letters in the current phrase
//         int phrasePoints = 0;
//         foreach (char c in userPhrase)
//         {
//             if (Char.IsLetter(c))
//             {
//                 phrasePoints++; // Add to phrase score
//                 totalPoints++;  // Add to total score

//                 // If the letter is one of the code letters, increment its count
//                 if (codeLetters.ContainsKey(c))
//                 {
//                     codeLetters[c]++;
//                 }
//             }
//         }

//         // Display the points earned for this phrase
//         Console.WriteLine("\nPoints for phrase #{0}: {1}", i, phrasePoints);
//         Console.WriteLine("Total points so far: {0}\n", totalPoints);
//     }

//     // Display total points (letters counted) after all phrases are entered
//     Console.WriteLine($"\nTotal points (letters counted): {totalPoints}");

//     // Show the 5 code letters and how many times they appeared
//     Console.WriteLine("\nThe 5 code letters and their counts are:");
//     foreach (var e in codeLetters)
//     {
//         Console.WriteLine("{0}: {1} times",e.Key, e.Value);
//     }

//prof answer

using Microsoft.Win32.SafeHandles;

Dictionary<char, int> codes = getCodes(5);
foreach(KeyValuePair<char, int> kvp in codes)
    {
        Console.WriteLine("{0}, {1}", kvp.Key, kvp.Value);
    }

guessingGame(5, codes);
static void guessingGame (int numGuesses, Dictionary<char,int> answers)
{
    int score = 0;
    string uPhrase = "";

    while(numGuesses > 0)
    {
        Console.WriteLine("You have {0} guesses left", numGuesses);
        Console.WriteLine("Enter a phrase:");
        score = 0;
        uPhrase = Console.ReadLine();

        foreach(char c in uPhrase)
        {
            // if(answers[c] == 1)
            //     score++;
            score+= answers[c];//will add either 1 or 0
            
        }//step through uphrase
        Console.WriteLine("Score for {0}, {1}", uPhrase, score);

    }



}//guessingGame

static Dictionary<char,int> getCodes(int numCodeLetters)
{
    Dictionary<char, int> rDictionary = new Dictionary<char, int>();
    //get five letters as code letters
    //set the keys to be a-z
    //unicide values for a-z are 97-122
    for(int i = 97; i < 123; i++)
        {
            rDictionary[(char)i] = 0;
            //set keys of rDictionary to be a-z
            //all of them have to have a value of 0
        }
    //set 5 random letters to be code letters
    Random r = new Random();
    int codeCount = 0;
    char randomChar = ' ';
    while(codeCount < numCodeLetters)
    {
        //pick a random letter
        randomChar = (char)r.Next(97, 123);
        //check to see if the letter is already a code letter
        if(rDictionary[randomChar] == 0)
        {
            //randomChar has not yet been set as a codeword
            rDictionary[randomChar] = 1;//set the value of the letter 1
        
            codeCount++;
        }//if
        //if the if isnt hit, that means that the randomchar value is already 
        //do nothing
        
    }//while
   
    return rDictionary;
}//getCodes method