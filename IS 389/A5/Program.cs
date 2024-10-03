//Name: Alexia Cervantes
//Description: Recipe tracker+ - The chef you helped create a program for tracking recipes read an article on data structure
//                               efficiency and wants an updated app.


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
            Dictionary<string, string> dishesIngr = new Dictionary<string, string>();

            //     b. Add the following key-value pairs
            //         i. Key: Pizza; Value: "Flour, Yeast, Salt, Tomato Sauce, Cheese"
            //         ii. Key: Hot Dog; Value: "Bun, Hot Dog"
            dishesIngr["Pizza"] = "Flour, Yeast, Salt, Tomato Sauce, Cheese";
            dishesIngr["HOt Dog"] = "Bun, Hot Dog";
            //     c. Call displayRecipes()
            displayRecipes(dishesIngr);
            //     d. Call exapandMenu()
            //         i. Add the most recent thing you ate
            expandMenu(dishesIngr);
            //     e. Call displayRecipes()
            displayRecipes(dishesIngr);
        }//main

        // Create two methods:
        //     a. displayRecipes()
        //         i. Has a void return type and a Dictionary <string, string> parameter
        //         ii. The method will display all dishes and ingredients in the parameter
        static void displayRecipes(Dictionary<string, string> meals)
        {
            foreach(KeyValuePair<string, string> KVP in meals)
            {
                Console.WriteLine("The ingredients in {0} are:\n{1}",KVP.Key, KVP.Value);
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
        static void expandMenu(Dictionary<string, string> newMeal)
        {

        }

    }//class
}//namespace