//Name: Alexia Cervantes
//Description: Create a program to help the chef manage both dishes and ingredients.

    // a. Create a list to keep track of dish names.
    List<string> dishNames = new List<string> { "Salad", "Fries" };

    // b. Create a list of lists to keep track of recipe items.
    List<List<string>> recipeItems = new List<List<string>>();

    // i. Add "Salad" recipe items at index 0
    List<string> salad = new List<string> { "Lettuce", "Ranch", "Croutons", "Shredded Parmesan" };
    recipeItems.Add(salad);

    // ii. Add "Fries" recipe items at index 1
    List<string> fries = new List<string> { "Potatoes", "Peanut oil", "Salt", "Pepper", "Sugar" };
    recipeItems.Add(fries);

    // c. Call displayRecipes()
    displayRecipes(recipeItems, dishNames);

    // d. Call expandMenu()
    expandMenu(recipeItems, dishNames);

    // e. Call displayRecipes() again to show the updated menu
    displayRecipes(recipeItems, dishNames);

// displayRecipes() method
// i. Void return type with two parameters: a list of lists and a non-jagged string list.
static void displayRecipes(List<List<string>> pJList, List<string> pList)
{
    for (int i = 0; i < pList.Count; i++)
    {
        // ii. Display dish name
        Console.WriteLine("\nThe ingredients for {0} are:", pList[i]);

        // iii. Display ingredients for the dish
        foreach (string ingredient in pJList[i])
        {
            Console.WriteLine("- {0}", ingredient);
        }
    }
}

// expandMenu() method
// i. Void return type with two parameters: a list of lists and a non-jagged string list.
static void expandMenu(List<List<string>> pJList, List<string> pList)
{
    // ii. Prompt for new dish name
    Console.Write("\nEnter the name of the new dish: ");
    string newDish = Console.ReadLine();

    // iii. Add new dish name to the dish list
    pList.Add(newDish);

    // iv. Prompt for number of ingredients
    Console.Write("How many ingredients does {0} have? ",newDish);
    int numIngredients = Convert.ToInt32(Console.ReadLine());

    // v. Prompt for ingredients input
    List<string> newIngredients = new List<string>();
    for (int i = 0; i < numIngredients; i++)
    {
        Console.Write("Enter ingredient {0}: ", i + 1);
        newIngredients.Add(Console.ReadLine());
    }

    // vi. Add new ingredients to the recipe list
    pJList.Add(newIngredients);
}
