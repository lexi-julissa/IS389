// Week 5 - 9.23.24

using System.Collections;

class week5
{
    public static void Main(string[]args)
    {
        sayHi();
        sayHi("Alexia");

        int x = 10;//only exists in the main after line 10 where it was declared because it does not exist yet
        x = 11;

        // for(int x = 10; x < 5; x++)//x cannot be declared because it already exists
        // {
        //     Console.WriteLine(x);
        // }

        //  for(int count = 10; count < 5; count++)
        // {
        //     Console.WriteLine(count);
        //     int x = 0; //x cannot be declared because it already exists
        // }

        // if(true)
        //     string x = "hi";//x cannot be declared because it already exists

        //DICTIONARIES
        Dictionary<string, string> stateCapitols = new Dictionary<string, string>();
        stateCapitols["Nevada"] = "Carson City";
        stateCapitols["California"] = "Sacremento";
        stateCapitols["Texas"] = "Austin";

        //Identifier.Add(key, value); to add value to dictionary
        stateCapitols.Add("Mississippi", "Jackson");
        //you cant have too of the same keys

        //to loop through just keys - KVP c an also be used
        foreach(string state in stateCapitols.Keys)
        {
            Console.WriteLine(state);
        }

        // Console.WriteLine(stateCapitols["Nevada"]);
        
        //Example Program:
        Console.WriteLine("What state would you like to know the capitol of?");
        string uInput = Console.ReadLine();

        //setting everything to upper to find the match
        //uInput = uInput.ToUpper();
        //how can i set the keys to upper without haveing to change the hardcode

        if (stateCapitols.ContainsKey(uInput))//if uInput == one of the keys in out dictionary .Containsvalue & .Contains for both
             Console.WriteLine(stateCapitols[uInput]);
        else
            Console.WriteLine("{0} not found! :(", uInput);

        //priceSheet Dic 
        Dictionary<string, double> priceSheet = new Dictionary<string, double>();
        priceSheet["Chewing Gum"] = 3.99;
        priceSheet["Soda"] = 4.99;
        priceSheet["Jerky"] = 8.99;

        //loop to add 10 items
        //items have a price of -1
        for(int i = 0; i < 10; i++)
        {
            priceSheet["Item " + i] = -1;
        }

        //looping through the data structure
        foreach(KeyValuePair<string, double> KVP in priceSheet)
        {
            Console.WriteLine("{0}, ${1}",KVP.Key, KVP.Value);
        }//foreaech KVP priceSheet

        //HASHTABLES
        Hashtable myTable = new Hashtable();
        myTable["Alan"] = "Instructor";
        myTable[12] = "even";
        myTable["password"] = true;

        myTable.Add("Note", "How to add");

        Console.WriteLine(myTable[12]);//to print out one exact key and value

        //To loop through all
        int count = 0;//to ccount each item
        foreach(DictionaryEntry de in myTable)
        {
            count++;
            Console.WriteLine("Item {0}", count);
            Console.WriteLine("{0}, {1}\n",de.Key, de.Value);
        }

        //unicode values (97-122) (a-z) lowercase
        Console.WriteLine('a');

        char myChar = 'b';
        Console.WriteLine(myChar);//outputs b

        char uniChar = (char) 99;
        Console.WriteLine(uniChar);//outputs c

        //EXCEPTIONS
        try
        {
            double cleanValue = 0;
            double someNum = 0;
            Console.WriteLine("Enter a number: ");
            if(Double.TryParse(Console.ReadLine(), out cleanValue))
                someNum = cleanValue;
            else    
                Console.WriteLine("Enter a number pls");
            //double someNum = Convert.ToInt32(Console.ReadLine());
        }
        catch
        {
            Console.WriteLine("Error!");
        }

        //OUT KEYWORD
        int outValue = 0;
        timesTwo(4, out outValue);
        Console.WriteLine(outValue);
         

    }//Main
    static void timesTwo(int num, out int numBack)
    {
        numBack = num * 2;
    }
    static void sayHi()
    {
        Console.WriteLine("Hi! :)");
        // x++; //wasnt declared in this method so it does not exist here
        double x = 5.5; //this is a different variable x they are not the same
    }//sayHi method no parameters
    static void sayHi(string name)
    {
        Console.WriteLine("Hi {0}! :)", name);
    }//sayHi method w/parameters
}//week5 class