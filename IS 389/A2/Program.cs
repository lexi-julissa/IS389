//Name: Alexia Cervantes
//Description: Assignment 2 - a program that will tell the user facts about their birth year using methods.

Console.WriteLine("What year were you born?");
int birthYear = Convert.ToInt32(Console.ReadLine());

divisibleBy(birthYear); 
//isLeapYear(birthYear); - does not need to be called twice

bool isLeap = isLeapYear(birthYear);

        //Output 
        if (isLeap)
        {
            Console.WriteLine("{0} is a leap year! :)", birthYear);
        }//if
        else
        {
            Console.WriteLine("{0} is not a leap year! :(", birthYear);
        }//else


 static void divisibleBy(int birthYear) {

        // Loop through numbers 2 to 10
        for (int i = 2; i <= 10; i++)
        {
            // Check if the number is divisible by i
            if (birthYear % i == 0)
            {
                Console.WriteLine("The year {0} is divisible by: {1}",birthYear, i);
            }//if statement
        }//for loop
}//divisibleBy method

static bool isLeapYear(int birthYear)
{
    if (birthYear % 4 == 0)
    {
        return true;
    }//if
    else
    {
        return false;
    }//else
}//isLeapYear