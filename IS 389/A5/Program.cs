//Name: Alexia Cervantes
//Description: Recipe tracker+ - The chef you helped create a program for tracking recipes read an article on data structure efficiency and wants an updated app.


using System.ComponentModel.DataAnnotations;

namespace A5
{
    class A5
    {
        static void Main(string[] args)
        {
            // In the Main method:
            //     a. Create a Dictionary <string, string> to keep track of dishes and ingredients.
            //         i. Keys are dish names
            //         ii. Values are ingredients
            Dictionary<string, string> recipes = new Dictionary<string, string>();

            //     b. Add the following key-value pairs
            //         i. Key: Pizza; Value: "Flour, Yeast, Salt, Tomato Sauce, Cheese"
            //         ii. Key: Hot Dog; Value: "Bun, Hot Dog"
            recipes["Pizza"] = "Flour, Yeast, Salt, Tomato Sauce, Cheese";
            recipes["Hot Dog"] = "Bun, Hot Dog";
            //     c. Call displayRecipes()
            displayRecipes(recipes);
            //     d. Call exapandMenu()
            //         i. Add the most recent thing you ate
            expandMenu(recipes);
            //     e. Call displayRecipes()
            displayRecipes(recipes);
        }//main

        // Create two methods:
        //     a. displayRecipes()
        //         i. Has a void return type and a Dictionary <string, string> parameter
        //         ii. The method will display all dishes and ingredients in the parameter
        static void displayRecipes(Dictionary<string, string> meals)
        {
            foreach(KeyValuePair<string, string> KVP in meals)
            {
                Console.WriteLine("\nThe ingredients in {0} are:\n{1}",KVP.Key, KVP.Value);
            }//foreaech KVP priceSheet
        }
        //     b. expandMenu()
        //         i. Has a void return type and a Dictionary <string, string> parameter
        //         ii. The method will prompt the user for input, asking what the name of the
        //         dish is
        //         iii. The method will prompt the user for the number of ingredients in the
        //         new dish
        //         iv. Prompt the user for as many inputs as the number of ingredients
        //         v. Add the ingredients as a string value with the new dish’s name as the key
        //         to the parameter
        static void expandMenu(Dictionary<string, string> updatedMeals)
        {
            Console.WriteLine("\nWhat is the name of your new dish?");
            string dishName = Console.ReadLine();

            Console.WriteLine("How many ingredients does {0} have?", dishName);
            int numIngredients = Convert.ToInt32(Console.ReadLine());

            List<string> newIngredients = new List<string>();

            for (int i = 0; i < numIngredients; i++)
            {
                Console.Write("Enter ingredient {0}: ", i + 1);
                newIngredients.Add(Console.ReadLine());
            }

            // Join the ingredients into a single string, separated by commas
            string ingredientsString = string.Join(", ", newIngredients);

            // Add the new dish and its ingredients to the dictionary
            updatedMeals.Add(dishName, ingredientsString);
        }

    }//class
}//namespace