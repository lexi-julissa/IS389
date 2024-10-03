//Week 3 - 9.11.24

//jagged structures
//arrays

string[][] groceryMatrix = new string[3][];
string[] fruits = {"apples", "peaches"};
string[] veggies = {"green beans", "broccoli", "carrots"};
string[] snacks = {"cheetos", "lays", "slim jims", "M+Ms"};

groceryMatrix[0] = fruits;
groceryMatrix[1] = veggies;
groceryMatrix[2] = snacks;

Console.WriteLine(groceryMatrix);//[][]
Console.WriteLine(groceryMatrix.Length);//3 arrays in this array
Console.WriteLine(groceryMatrix[0]);//[]
Console.WriteLine(groceryMatrix[0].Length);//2 in that array
Console.WriteLine(groceryMatrix[0][1]); //peaches

Console.WriteLine("\n\n\n\n\n\n");//spacing



//looping through a jagged structure

for(int outer = 0; outer < groceryMatrix.Length; outer++)
{
    for(int inner = 0; inner < groceryMatrix[outer].Length; inner++)
    {
        //Console.WriteLine("[{0}], [{1}]", outer, inner); //displays the array indicies
        //Console.WriteLine("{0}\t" ,groceryMatrix[outer][inner]); //displays all content within the jagged array
        //groceryMatrix[outer][inner] = "detergent"; //makes all the content display as "detergent"
        Console.WriteLine("{0}\t" ,groceryMatrix[outer][inner]);

    }//inner
    Console.WriteLine("\n");

}//outer

Console.WriteLine("\n\n\n\n\n\n");//spacing

//foreach
foreach(string[] a in groceryMatrix)
{
    foreach(string item in a)
    {
        Console.WriteLine(item);
    }
    Console.WriteLine("\n");

}

Console.WriteLine("\n\n\n\n\n\n");//spacing


printJaggedArray(groceryMatrix);

//print jagges array method
//void returun, sting[][] parameter
//outputs the elements in the parameter


static void printJaggedArray(string[][] pJArray)
{
    int outer = 0;
    while(outer < pJArray.Length)
    {
        int inner = 0;
        while(inner < pJArray[outer].Length)
        {
            Console.WriteLine("{0}\t", pJArray[outer][inner]);
            inner++;

        }
        Console.WriteLine("\n");
        outer++;
    }
}

Console.WriteLine("\n\n\n\n\n\n");//spacing

//in class activity


//manual number bank
int[][] nums = new int[3][];
int[] ones = {1, 2, 3, 4, 5};
int[] tens = {12, 24, 36, 48, 50};
int[] hundreds = {136, 293, 369, 436, 539};

nums[0] = ones;
nums[0] = tens;
nums[0] = hundreds;

//generated num bank 5x5
//int[][] return, no parameters
//retuns an int[][] 
//each element is randomized 1-20

static int[][] generateFiveByFive()
{
    int[][] rMatrix = new int [5][];
    Random r = new Random();

    //create an array, assign it to an index of rmatric
    //loop through matic 0-4
    //each loop, loop through the array 0-4 assigning .next values
    //of 1, 21

    for(int i = 0; i < rMatrix.Length; i++)
    {
        int[] tempArray = new int [5];
        for(int inner = 0; inner< tempArray.Length; inner++)
            tempArray[inner] = r.Next(1,21);
        rMatrix[i] = tempArray;
    }
    return rMatrix;
}

static void printJaggedArray(int[][] pJArray)
{
    foreach(int [] array in pJArray)
    {
        foreach (int num in array)
        {
            Console.WriteLine("{0}\t", pJArray);
        }
        Console.WriteLine();
    }
}//FIX


int[][] myNumbers =generateFiveByFive();
numberMuncherANS(myNumbers, 5);
printJaggedArray(myNumbers);

printJaggedArray(generateFiveByFive());

numberMunchers(nums, 5);
//numberMuncher method

static void numberMunchers(int[][] pJArray, int NumDivisible)
{
    foreach(int[] n in pJArray)
    {
        for(int inner = 0; inner < n.Length; inner++)
        {
            if(n[inner] % NumDivisible == 0)
            {
                n[inner] = 0;
            }
            
        }
        Console.WriteLine("\n");
    }
}

static void numberMuncherANS(int[][] pJArray, int divisible)
{
    for(int o = 0; o< pJArray.Length; o++)
    {
        int inner = 0;
        while(inner < pJArray[o].Length)
        {
            if(pJArray[o][inner] % divisible ==0)
                pJArray[o][inner] = 0;
            inner++;
        }
    }
}

//relevent to hw
List<string> computerStuff = new List<string>();
computerStuff.Add("mouse");
computerStuff.Add("keyboard");
computerStuff.Remove("mouse");
computerStuff.RemoveAt(0);


List<string> snack = new List<string>();
snack.Add("Gum");

List<List<string>> electronicStore = new List<List<string>>();
electronicStore.Add(computerStuff);
electronicStore.Add(snack);

electronicStore.Remove(snack);


Console.WriteLine(electronicStore[1][1]);



