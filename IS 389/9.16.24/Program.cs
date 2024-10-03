//Week 4 - 9.16.24

//NULL

//not the same as 0 or blank - those are still values

//string nonNullable = null; //you need the ? to declare it as null
using System.ComponentModel;

string? nullable = null;

//Console.WriteLine(nonNullable);
Console.WriteLine(nullable);

//int nonNullableInt = null; //you need the ? to declare it as null
int? nullableInt = null;

//Console.WriteLine(nonNullableInt);
Console.WriteLine(nullableInt);

//VAR

var a = "hello"; //now a string
var b = 10.5; //now a double
var r = new Random(); //now a random object

Console.WriteLine(a + "world");
Console.WriteLine(b*2);
Console.WriteLine(r.Next(1, 100));

//some more examples

//EXCEPTION HANDLING

//ask the user to try again if not valid

bool isInvalid = true;
do
{
Console.WriteLine("Enter a username:");
isInvalid = String.IsNullOrEmpty(Console.ReadLine());
if(isInvalid)
    Console.WriteLine("You cannot enter blank!");
}while(isInvalid); //loop while users input is in valid


//DATA VALIDATION

string exString = "CaT";
Console.WriteLine(exString.Length); //shows you the num of char values in that string
//spaces, special charcters and numbers count too

char[] toxenizedString = exString.ToCharArray();//creates an array from the characters of this array
Console.WriteLine(toxenizedString[0]);//will output the character in that index

//you cannot modify charcters in a string only in an array

//output the number of time 'a' appears in ex2String
int count = 0;
char toFind = 't';
foreach(char letter in exString) //toxenizedString can also be used
{
    if(Char.ToLower(letter) == toFind)//changes all characters to lowercase so every char is counted
        count++;
}
Console.WriteLine("'{0}' appears {1} time(s) in '{2}'", toFind, count, exString);


Console.WriteLine("Enter text to be checked:");
string text = Console.ReadLine();
// Console.WriteLine("Enter letter for checking");
// char letter = Console.ReadLine();

char toFind2 = 'T';
Console.WriteLine("The character '{0}' appears {1} time(s) in '{2}'", toFind2, letterCounter(text,toFind2, false), text);


//letter counter method
//returns how many times that letter appears in that string
static int letterCounter(string textToCount, char toFind, bool ignoreCase)
{
int count = 0;
foreach(char letter in textToCount)
{
    switch(ignoreCase)
    {
        case true:
            if(Char.ToLower(letter) == Char.ToLower(toFind))
                 count++;
        break;
        default:
            if(letter == toFind)
                 count++;
        break;
    }

    
}
return count;
}

//EXCEPTIONS
Console.WriteLine("Enter a number:");
int uNum = Convert.ToInt32(Console.ReadLine());

//continuation 9/18/24

try
{
Console.WriteLine("Enter a number to divide by 10");
int uNum5 = Convert.ToInt32(Console.ReadLine());
int answer = 10/ uNum5;
Console.WriteLine(answer);
}
catch(FormatException)
{
    Console.WriteLine("Please enter a whole number!");
}
catch(DivideByZeroException)
{
    Console.WriteLine("cannot divide by zero!");
}
catch //general catch taht catches everything
{
    Console.WriteLine("Something went wrong!");
}


//out key word
int myNum = 0;
plusOne(5, out myNum);
Console.WriteLine(myNum);

static void plusOne( int numToAdd, out int newNum)
{
    newNum = numToAdd'
    numToAdd++;
}