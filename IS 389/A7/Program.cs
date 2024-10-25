//Name: Alexia Cervantes
/*Description: A console application that can administer math quizzes to the user, but with 4 difficulty levels that dynamically
change based on user performance.*/

namespace A7
{
    delegate bool MathQuizDele();//delegate for the event //with a bool parameter (event)
    class A7
    {
        public static void Main (string[]arg)
        {
            bool keepGoing = true;
            // Repeat until the user wants to stop:
            while(keepGoing)
            {
                // i. Tell the user number of correct and incorrect answers so far

                // ii. Tell the user the current difficulty level, default difficulty is level 2
                // 1. There are 4 difficulty levels:
                // a. On level 1, only addition problems are shown to the user
                // b. On level 2, addition and subtraction problems are shown
                // c. On level 3, addition, subtraction, and multiplication problems are shown
                // d. On level 4, addition, subtraction, and division problems are shown
                // iii. Display a random math problem to the user with 2 integer values between 1 – 10 based on
                // difficulty level
                // iv. Round the answer to the 2nd decimal point
                // v. Increase the difficulty if the user gets 2 questions correct in a row
                // vi. Decrease the difficulty if the user gets 2 questions incorrect in a row
            }
        }//main
    }//class A7
    class DifficultyManager//Create a publisher class:
    {
        // a. Create an event called ChangeDifficulty with a bool parameter
        public event MathQuizDele MathQuizEvent;

        // b. Create a method called OnChangeDifficulty to invoke the event
        public void OnChangeDifficulty()//instance method
        {
            MathQuizEvent.Invoke();
        }
    }//DifficultyManager Class
    class DifficultyTracker//Create a subscriber class:
    {
        // a. Create a way to track the difficulty level. Hint: a static variable would be useful here
        public static string level;
        // b. Create a method called AdjustDifficulty with an Object and bool parameter. The method will either
        // increase the difficulty if the bool is true or decrease it is if it false
    }//DifficultyTracker class
}//namespace A7
