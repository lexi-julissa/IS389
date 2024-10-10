//Name: Alexia Cervantes
//Description: a Console application that can administer math quizzes to the user using delegates.


namespace A6
{

    class A6
    {
        // b. Create a delegate with a double return and 2 double parameters
        public delegate double functionDele(double x, double y);
        static void Main(string[] args)
        {
            functionDele mathBot = new functionDele(addition);
            

            int correct = 0;
            int incorrect = 0;

            Random r = new Random();

            while(correct < 5 && incorrect < 5)// Repeat until the user gets 5 correct answers or 5 incorrect answers:
            {
                // i. Tell the user number of correct and incorrect answers so far
                Console.WriteLine("\nNumber of correct answers: {0}", correct);// ii. Display a random math problem to the user with integer values between 1 – 10
                Console.WriteLine("Number of incorrect answers: {0}", incorrect);

                string operation = "";

                double num1 = r.Next(1,11);
                double num2 = r.Next(1,11);
                

                switch(r.Next(1,5))
                {
                    case 1:
                        operation = "+";
                        mathBot = addition;
                    break;
                    case 2:
                        operation = "-";
                        mathBot = subtraction;
                    break;
                    case 3:
                        operation = "*";
                        mathBot = multiplication;
                    break;
                    case 4:
                       operation = "/";
                       mathBot = division;
                       // Ensure no division by zero
                       if (num2 == 0) num2 = 1;
                    break;
                }
                Console.WriteLine("What is {0} {1} {2}?",num1, operation, num2);

                // iii. Use the delegate to check the user’s answer
                double correctAnswer = Math.Round(mathBot(num1, num2), 2); // Round the answer to the 2nd decimal point

                // Get the user's answer as a double
                double userAnswer = Convert.ToDouble(Console.ReadLine());

                // Compare the user's answer to the correct answer
                if (Math.Round(userAnswer, 2) == correctAnswer)
                {
                    Console.WriteLine("Correct!");
                    correct++;
                }
                else
                {
                    Console.WriteLine("Incorrect! The correct answer was {0}",correctAnswer);
                    incorrect++;
                }

            }//while loop

            // End of game message
            if (correct == 5)
            {
                Console.WriteLine("Congratulations, you won!");
            }
            else
            {
                Console.WriteLine("Game over, you lost!");
            }
            
        }//Main
        // In the Class:
        // a. Create 4 methods:

        // i. Add
        // ii. All have double return type and 2 double parameters
        // iii. All return the math result of the 2 double parameters based on method name
        static double addition (double num1, double num2)
        {
            return num1 + num2;

        }//addition method

        // i. Subtract
        // ii. All have double return type and 2 double parameters
        // iii. All return the math result of the 2 double parameters based on method name
        static double subtraction (double num1, double num2)
        {
            return num1 - num2;
        }//subtraction method

        // i. Multiply
        // ii. All have double return type and 2 double parameters
        // iii. All return the math result of the 2 double parameters based on method name
        static double multiplication (double num1, double num2)
        {
            return num1 * num2;
        }//multiplication method

        // i. Divide
        // ii. All have double return type and 2 double parameters
        // iii. All return the math result of the 2 double parameters based on method name
        static double division (double num1, double num2)
        {
            return num1 / num2;
        }//division method
    }//class
}//namespace


