//Week 4 - 9.18.24

//In class activity


using System.Runtime.InteropServices;

Console.WriteLine("Lets play Wordle!");

//set five letter word
string wordleAns = "adapt";

//6 attempts to guess the answer

for (int i = 6; i > 0; i--)
{
    Console.WriteLine("Guess the five letter word: \n'{0}' tries remaining", i);
    string guess = Console.ReadLine().ToLower();

     // Check if the guess is 5 letters long and is only made up of letters
    if (guess.Length != 5 || !guess.All(char.IsLetter))
        {
            Console.WriteLine("Try again, enter a 5-letter word containing only letters a-z.");
            i++;//doesn't count as a try
        }


    //If a letter is in the correct spot, tell the user that the letter in that position is correct
    for (int l=0; l < 5; l++)
    {   
        if(guess[l] == wordleAns[l])
            Console.WriteLine("You guessed the letter {0} in the correct spot",guess[l]);
        else//testing not working 100%
        {
            bool letterInAns = false;
                                foreach(char ansLetter in wordleAns)
                                    {
                                        if(guess[i]==ansLetter)
                                            letterInAns = true;
                                    }
                                if(letterInAns)
                                    Console.WriteLine("{0} at position {1} is part of the answer",wordleAns[i], i+1 );
        }
        //     for (int v=0; v < 5; v++){
        //         if (wordleAns[l] == guess[v])
        //             Console.WriteLine("{0} is in the word but in the wrong spot",wordleAns[l]);
        // }
    }

    //If a letter is present in the answer but not in the correct spot, tell the user that the letter is present


    // Check if the guess matches the answer
    if (guess == wordleAns)
        {
            Console.WriteLine("Congratulations! You've guessed the correct word!");
            i = 0;
        }


    // If out of attempts, reveal the correct word
        if (i == 1)
        {
            Console.WriteLine("Game over! You have no more tries :( \nThe correct word was: {0}", wordleAns);
        }

}

//prof wordle answer
wordle(5, 6, "train");

static void wordle(int sizeAnswer, int numAttempts, string answer)
{
    bool isCorrect = false;

    for(int guess = 0; guess <numAttempts && !isCorrect; guess++)
    {
        Console.WriteLine("Yo have {0} guesses remaining", numAttempts - guess);
        Console.WriteLine("Enter your guess:");
        string uGuess = Console.ReadLine();

        bool isValid = true;
        if(uGuess.Length != sizeAnswer)
            isValid = false;
        else    
        {
            foreach(char letter in uGuess)
                {
                    if(!Char.IsLetter(letter))
                        isValid = false;
                }
        }//checks before comparison

        if(isValid)
        {
            answer = answer.ToLower();
            uGuess = uGuess.ToLower();

            if(answer == uGuess)
            {
                Console.WriteLine("Correct");
                isCorrect=true;
            }
            else
            {
                for(int i =0; i < uGuess.Length; i++)
                {
                    if(uGuess[i] == answer[i])
                        Console.WriteLine("{0} at position {1} is correct", uGuess[i], i+1);
                    else 
                        {
                            bool letterInAns = false;
                            foreach(char ansLetter in answer)
                                {
                                    if(uGuess[i]==ansLetter)
                                        letterInAns = true;
                                }
                            if(letterInAns)
                                Console.WriteLine("{0} at position {1} is part of the answer",uGuess[i], i+1 );
                        }//guess is not completly correct
                }//for loop
            }//checking answer and guess
        }
        else
            Console.WriteLine("Guess needs to be five letters!");
        Console.WriteLine("");

    }
}