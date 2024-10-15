//Exam 1 Review

//Recap: Variables, bool, methods
using System.ComponentModel.DataAnnotations;
delegate void smallTakDele(string n);


string brand = "Nike";
int x =10;
char letter = (char) 100;

Console.WriteLine("{0} {1} {2}", brand, x, letter);

Console.WriteLine("\nEnter a password:");
string uInput = Console.ReadLine();
//count the number of letters and numbers
//display both back to user

int letterCount = 0;
int numCount = 0;

foreach(char c in uInput)
{
    if(Char.IsLetter(c))
        letterCount++;
    if(Char.IsNumber(c))
        numCount++;
}//foreach
Console.WriteLine("{0} contains {1} letters and {2} numbers :)",uInput, letterCount, numCount);

//data structures, arrays and lists
string[] colors = {"Red", "Yellow", "Blue"};
for(int i = 0; i < colors.Length; i++)
{
    Console.WriteLine(colors[i]);
}
 List<double> numbers = new List<double> {1.1, 2.2, 3.3};
 int n = 0;
 numbers.Add(1.12);
 numbers.Remove(3.3);
 numbers.RemoveAt(0);//removes what is at index of 0

modifyValue(numbers, 2.2);

 while( n < numbers.Count)
 {
    Console.WriteLine(numbers[n]);
    n++;
 }

//jagged data structures
string[][]  recipes = new string[2][];
string[] bread = {"flour", "water","yeast"};
string[] salad = {"lettuce", "tomato"};
recipes[0] = bread;
recipes[1] = salad;

foreach(string[] dish in recipes) 
{
    foreach(string ingredient in dish)
        Console.WriteLine(ingredient);
    Console.WriteLine("");
}

//Dictionaries
Dictionary <string, List<string>> recipeBook = new Dictionary<string, List<string>>();
List<string> breadIng = new List<string>{"flour","water", "yeast"};
List<string> burgerIng = new List<string>{"bun","patty", "lettuce"};
recipeBook["bread"] = breadIng;
recipeBook["hamburger"] = burgerIng;
recipeBook["hamburger"].Add("mayo");
foreach(KeyValuePair<string, List<string>> kvp in recipeBook)
{
    Console.WriteLine("\nThe ingredients in {0} are:",kvp.Key);
    foreach(string ing in kvp.Value)
        Console.Write("{0}", ing);
}

Console.WriteLine(babble2(5,3));

//delegates

smallTakDele talkBot = new smallTakDele(sayHi);
talkBot+= sayBye;
talkBot("Alexia");



//methods

//smalltalk
static void sayHi(string name)
{
    Console.WriteLine("Hi {0}", name);
}
static void sayBye(string name)
{
    Console.WriteLine("Bye {0}", name);
}
//babble2
static string babble2(int wordCount, int letterCount)
{
    string rPhrase = "";
    string tempString = "";
    Random r = new Random();
    for(int o = 0; 0 <wordCount; o++)
    {
        tempString = "";
        for(int i = 0; i < wordCount; i++)
        {
            tempString = tempString + (char) r.Next(97,123);
        }
        rPhrase = rPhrase + tempString + " ";
    }

    return rPhrase;
}


//modifyValue void retun, list parameter, double parameter
//will see if present then will ask what to change it to
static void modifyValue(List<double> pList, double searchNum)
{
    double newDouble = 0;
    for ( int i = 0; i < pList.Count; i++)
    {
        if(pList[i] == searchNum)
        {
            Console.WriteLine("{0} found, enter new number",searchNum );
    
            if(Double.TryParse(Console.ReadLine(), out newDouble))
                pList[i] = newDouble;
            else
                Console.WriteLine("Invalid input!");
        }
    }
}
