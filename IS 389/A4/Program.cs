//Name: Alexia Cervantes
//Description: Assignment 4 - Create a program to set and enforce password policies.

// 4) Call setPolicy() and use the returned int[] as an argument for PolicyTester()
PolicyTester(setPolicy());

// Create a method called setPolicy() with an int[] return and no parameters. The method will ask for the following:
static int[] setPolicy()
{
    bool isInvalid = true;
    int minLength = 0, minLetters = 0, minNumbers = 0;

    do    // d. Validate that each user input is an integer numeric. If the user enters an invalid input, tell them and ask for the same item again.
    {
        // a. Minimum length of passwords
        // i. Must be between 5 - 20
        Console.WriteLine("Enter minimum length of password: **Must be between 5-20**");

        string input = Console.ReadLine();

        // Check if the input is a valid integer and within the required range
        isInvalid = !int.TryParse(input, out minLength) || minLength < 5 || minLength > 20;

        if (isInvalid)
            Console.WriteLine("Invalid input. Try again! **Must be between 5-20**");

    } while (isInvalid); // Loop while user input is invalid

    do    // d. Validate that each user input is an integer numeric. If the user enters an invalid input, tell them and ask for the same item again.
    {
        // b. Minimum amount of letters
        // i. Cannot exceed minimum length
        Console.WriteLine("Enter minimum amount of letters: **Cannot exceed minimum length of {0}**", minLength);

        string input = Console.ReadLine();

        // Check if the input is a valid integer and within the required range
        isInvalid = !int.TryParse(input, out minLetters) || minLetters > minLength;

        if (isInvalid)
            Console.WriteLine("Invalid input. Try again! **Must be less than or equal to {0}**", minLength);

    } while (isInvalid); // Loop while user input is invalid

    do    // d. Validate that each user input is an integer numeric. If the user enters an invalid input, tell them and ask for the same item again.
    {
        // c. Minimum amount of numbers
        // i. Cannot exceed minimum length
        Console.WriteLine("Enter minimum amount of numbers: **Cannot exceed the remaining length of {0}**", minLength - minLetters);

        string input = Console.ReadLine();

        // Check if the input is a valid integer and within the required range
        isInvalid = !int.TryParse(input, out minNumbers) || minNumbers > (minLength - minLetters);

        if (isInvalid)
            Console.WriteLine("Invalid input. Try again! **Must be less than or equal to {0}**", minLength - minLetters);

    } while (isInvalid); // Loop while user input is invalid

    // e. After three valid values are entered, return an array containing the three values.
    // i. For example: a return of [8, 4, 4] means passwords must be: 
    // minimum 8 characters with 4 letters and 4 numbers
    return new int[] { minLength, minLetters, minNumbers };
}//setPolicy method

// Create a method called PolicyTester() with a void return and an int[] parameter. 
static void PolicyTester(int[] requirements)
{
    //The method will repeatedly ask the user for passwords to test and tell the user if the password meets the policy based on the int[] parameter.
    
    // Extract the requirements from the array
    int minLength = requirements[0];
    int minLetters = requirements[1];
    int minNumbers = requirements[2];

    string password;
    bool meetsLength, meetsLetters, meetsNumbers;
    
    do
    {
        Console.WriteLine("Enter a password to test (or type 'exit' to quit):");
        password = Console.ReadLine();

        // Exit the loop if the user types "exit"
        if (password.ToLower() == "exit")
            break;

        // a. After each entered password, output the following:
        
        // i. Whether the password meets the length requirement
        meetsLength = password.Length >= minLength;

        // ii. Whether the password meets the letter requirement
        int letterCount = password.Count(char.IsLetter);
        meetsLetters = letterCount >= minLetters;

        // iii. Whether the password meets the number requirement
        int numberCount = password.Count(char.IsDigit);//isDigit is .isletter but for numbers
        meetsNumbers = numberCount >= minNumbers;

        // Output the results
        // i. Output whether the password meets the length requirement
        if (meetsLength)
        {
            Console.WriteLine("Meets length requirement of {0} characters: Yes", minLength);
        }
        else
        {
            Console.WriteLine("Meets length requirement of {0} characters: No", minLength);
        }

        // ii. Output whether the password meets the letter requirement
        if (meetsLetters)
        {
            Console.WriteLine("Meets letter requirement of {0} letters: Yes", minLetters);
        }
        else
        {
            Console.WriteLine("Meets letter requirement of {0} letters: No", minLetters);
        }

        // iii. Output whether the password meets the number requirement
        if (meetsNumbers)
        {
            Console.WriteLine("Meets number requirement of {0} numbers: Yes", minNumbers);
        }
        else
        {
            Console.WriteLine("Meets number requirement of {0} numbers: No", minNumbers);
        }

        Console.WriteLine(); // Add a line for readability

    } while (true); // Keep testing passwords until the user types "exit"
}


