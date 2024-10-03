//Week 3 - 9.9.24

Console.WriteLine("\n\n\n\n\n\n");//spacing

////LOOPS

//for loop

for(int i = 0; i < 10; i++) //starts at 0, keeps going as long as is <10, adds one at a time i-- will make it decrease by 1 each timr
//putting true instead of i < 10 will also create an infinte loop
//false will make it never start
{
    //i = 0; //infinte loop - will always reset to 0
    Console.WriteLine(i);
}//for-loop


//while loop

int count = 5;
while(count < 50)
{
    count++;
    Console.WriteLine(count);
}//while-loop

//do-while loop

int someNum = 10;
do
{
    Console.WriteLine(someNum);
}while(someNum < 0);//stops because 10 < 0 is false, put prints the 10 because rule is after

////PRACTICE

//ask user for username
//repeat until they type somethng that is not blank
string uInput = "";
//bool containsSomething = uInput != ""; //-one way to do it
bool isBlank = String.IsNullOrEmpty(uInput);//THIS SAME

do{
    Console.WriteLine("Please enter a username: ");
    uInput = Console.ReadLine();
    isBlank = uInput == "" || uInput == null; //THIS SAME
}while(isBlank);//loop until uInput is not blank

////NESTED LOOPS

for(int outer = 0; outer < 3; outer++)
{
    for(int inner = 0; inner < 2; inner++)
    {
        Console.WriteLine("{0}, {1}",outer, inner);
    }//for inner loop
}//for outer loop

for(int outer = 0; outer < 4; outer++)
{
    int inner = 0;
    while(inner < 3)
    {
        Console.WriteLine("{0}, {1}",outer, inner);
        inner++;
    }//while inner loop
}//for outer loop


////DATA STRUCTURES

//arrays

//default types
//string = blank
//int = 0
//bool = false
//objects = null

string[] snacks = new string[4];
snacks[0] = "Cheetos";
snacks[1] = "Slim Jims";
//manually outputing each index
Console.WriteLine(snacks[0]);
Console.WriteLine(snacks[1]);


//lists

List<int> evenNumbers = new List<int>();

//arrays have a set size
//lists do not - you can add and delete as you please 

// evenNumbers.Add(10);
// Console.WriteLine(evenNumbers[0]); //displays 10

//add the first 1000 even numbers to our list
int toAdd = 2;
for(int i = 0; i < 1000; i++)
{
    evenNumbers.Add(toAdd);
    toAdd+=2; // will increase by 2 each time
}//for loop evenNumbers list

//to display the numbers - for loop
for(int i = 0; i < evenNumbers.Count; i ++) //.count will display the whole amount in that list - .length for arrays
{
    Console.WriteLine(evenNumbers[i]);
}//for loop to display evenNumbers

//randomize heads or tails using an array, 1000 flips
//count the number of heads and tails in an array
string[] flips = new string [1000];
Random r = new Random();
for(int i = 0; i < flips.Length; i ++)
{
    if(r.Next(0, 2) == 0)
        flips[i] = "Heads";
    else
        flips[i] = "Tails";
}

//foreach loop

//to count the number of heads and tails
int numH = 0;
int numT = 0;
foreach(string result in flips)
{
    if(result == "Heads")
        numH++;
    else    
        numT++;
}///foreach loop
Console.WriteLine("Number of heads: {0}\nNumber of tails: {1}",numH, numT);

string[] myFlips = generateFlips(10000);
countFlips(myFlips);

// foreach(string flipResult in generateFlips(100))
//     Console.WriteLine(flipResult); //another way to output it

countFlips(generateFlips(5000)); //another way to output it 

//lets create  methods for this instead
//generateFlips() and countFlips()

//generateFlips has a string[] return and an int parameter
//method will return a string[] containg as many instances of 
//"Heads" or "Tails as the in parameter

static  string[] generateFlips(int numFlips)
{
    string[] rArray = new string[numFlips];
    int i = 0;
    Random r = new Random();
    while(i < rArray.Length)
    {
        if(r.Next(0,2)==0)
            rArray[i] = "Heads";
        else    
            rArray[i] = "Tails";
        i++;
    }
    return rArray;
}

//countFlips has a void return and a string[] parameter
//method will output the number of "Heads" and "Tails in the 
//string[] parameter

static void countFlips(string[] pArray)
{
    int numHeads = 0;
    int numTails = 0;

    foreach(string item in pArray)
    {
        if (item == "Heads")
            numHeads++;
        else
            numTails++;
    }
    Console.WriteLine("Heads: {0}\nTails: {1}", numHeads, numTails);
}


////JAGGED ARRAY
//an array of arrays

string[][] groceryAisles = new string[3][];

string[] veggies = {"celery", "cauliflower", "carrots"};
groceryAisles[0] = veggies;

Console.WriteLine(groceryAisles); //an array of string arrays
Console.WriteLine(groceryAisles[0]); //a string array - veggies
Console.WriteLine(groceryAisles[0][0]); //[0] inside the veggies array - celery
Console.WriteLine(groceryAisles[0][2]); //[2] inside the veggies array - carrots


