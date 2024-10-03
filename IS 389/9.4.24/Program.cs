//Week 2 - 9.4.24

//escape characters 
using System.Collections;
using System.Diagnostics;
using System.Runtime.InteropServices;

Console.WriteLine("\n\n\n\n\n\n");

////REVIEW OF IS350

////VARIABLES
//variable type  name = what it is
string school = "UNR";
int numCookies = 5;
double pressure = 5.9;
bool isCold = false;

Console.WriteLine("I go to " + school);
Console.WriteLine("I go to {0} and have {1} cookies" , school, numCookies);

//string
Console.WriteLine("Enter your name:");
string uName = Console.ReadLine();
Console.WriteLine("Hello {0}!", uName);

//int 
Console.WriteLine("Enter a number:");
int uNum = Convert.ToInt32(Console.ReadLine()); //needs to be converted
//int uNum = Convert.ToInt32(uNum); //another way to convert
Console.WriteLine("{0} * 2 = {1}", uNum, uNum * 2);

////BOOLEAN

//even or odd program
//indicates weather a number is even or odd
if(uNum % 2 == 0){//if remainder of x / 2 = 0 
    Console.WriteLine("{0} is even! :)", uNum);
}//if
else{
    Console.WriteLine("{0} is odd! :(", uNum);
}//else

//switch-case statement
Console.WriteLine("Enter a password: ");
switch(Console.ReadLine()){
    case "password":
        Console.WriteLine("Password is too common! >:(");
    break;

    case "abc123":
        Console.WriteLine("Password is too easy to guess! >:(");
    break;

    default: 
        Console.WriteLine("Password is set! :)");
    break;
}//switch-case

//Methods

//sayHello("Alexia");

//random
// Random r = new Random();
// Console.WriteLine(r.Next(5,10)); //returns a number from 5-9
// //if you need multiple randoms just call .Next again, no need to do random r = new random again

//Console.WriteLine(randomName());

//How do we call sayHello using the return of randomName as the argument
sayHello(randomName());

//capture user input for two numbers
//display weather the numbers are divible by each other based on a call to divisibleBy
Console.WriteLine("Enter 2 numbers:");
int num1 = Convert.ToInt32(Console.ReadLine());
int num2 = Convert.ToInt32(Console.ReadLine());
if(divisibeBy(num1, num2))
    Console.WriteLine("{0} and {1} are divisible! :)", num1, num2);
else
    Console.WriteLine("{0} and {1} are not divisible! :(", num1, num2);

//divisibeBy method
//two numbers
//checks to see if either number is divisible by the other
//bool return, true of so, false otherwise
static bool divisibeBy(int num1, int num2){
    if(num1 % num2 == 0)
        return true;
    else if(num2 % num1 == 0)
        return true;
    else    
        return false;
}//divisibleBy method

static void sayHello(string name){ //void returns nothing
    Console.WriteLine("Hello {0}", name);
}//sayHello method

static string randomName(){
    Random r = new Random();
    switch(r.Next(0,3)){
        case 0:
            return "bob";
            break;

        case 1:
        return "sara";
            break;

        case 3:
            return "jess";
            break;
    }//switch-case
    return "";//makes error go away
}