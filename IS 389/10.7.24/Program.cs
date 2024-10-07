//week 7 - 10.7.24

using System.Data.Common;
using System.Net.Http.Headers;
using System.Runtime.CompilerServices;
using Microsoft.Win32.SafeHandles;

namespace Week7
{
    class Cat
    {
        string name;
        static string[] possibleMoods = {"hungry", "sleepy"};
        string mood;
        public Cat(string n)//public makes it visible outside of the class
        {
            name = n;
            Random r = new Random();
            mood = possibleMoods[r.Next(0, possibleMoods.Length)];//sets mood randomly to hungry or sleepy
        }//constructor 
        public void sayMeow()
        {
            Console.WriteLine("{0} is {1}",name ,mood);
            if(mood== possibleMoods[1])
                Console.WriteLine("{0} says meow softly!", name);
            else
                Console.WriteLine("{0} says meow loudly!", name);
        }//sayMeow method
        public void eatStuff()
        {
            if(mood==possibleMoods[0])
                Console.WriteLine("{0} ate a lot of food!", name);
        }//eatStuff method
        public void takeNap()
        {
            if(mood==possibleMoods[1])
                Console.WriteLine("{0} takes a longgggg nap!", name);
        }//takeNap method
    }//cat class
    //creating delegates
    public delegate void catDele();

    public delegate bool numberCheckDele(int x);

    class Week7
    {
        //isEven
        static bool isEven(int num)
        {
            if(num % 2 == 0)
                Console.WriteLine("{0} is even", num);
            else
                Console.WriteLine("{0} is odd", num);
            return num % 2 == 0;
        }//isEven method

        //isPositive
        static bool isPositive(int num)
        {
            if(num > 0)
                Console.WriteLine("{0} is positive", num);
            else
                Console.WriteLine("{0} is negative", num);
            return num > 0;
        }//ispositive method

        //isDivisible by 3
        static bool isDivisbleByThree(int num)
        {
            if(num % 3 == 0)
                Console.WriteLine("{0} is divisible by 3", num);
            else
                Console.WriteLine("{0} is not divisible by 3", num);
            return num % 3 == 0;
        }//is divisble by three method

        //updateCatBot
        //void return
        //cat object parameter, catDele parameter
        //associate the sayMeow, eatStudd, takeNap methods of the cat parameter to the cat dele parameter
         static void updateCatBot(Cat pCat, catDele pcatDele)
        {
            //link pcatdele to a new catdele
            pcatDele = new catDele(pCat.sayMeow);
            pcatDele += pCat.eatStuff;//link eatstuff
            pcatDele += pCat.takeNap;//link takeNap

            pcatDele();
        }//updatecat method
        static void sayHello(string name)
        {
            Console.WriteLine("Hi {0}", name);
        }
        static void sayBye(string name)
        {
            Console.WriteLine("Bye {0}", name);
        }
        public static void Main(string[]arg)
        {
            Console.WriteLine("\n\n\n\n\n\n");//spacing

            //CLASS REVIEW
            Cat C1 = new Cat("Garfield");//visibility - needs the constructor to be public
            Cat C2 = new Cat("Luna");
            
            // //CAT DELEGATES - hard coded
            // catDele CatBot = new catDele(C1.sayMeow);
            // CatBot += C1.eatStuff;
            // CatBot += C1.takeNap;
            // CatBot();

            // Console.WriteLine("Setting up the next cat...");
            // Thread.Sleep(3000);
            // CatBot = new catDele(C2.sayMeow);
            // CatBot += C2.eatStuff;
            // CatBot += C2.takeNap;
            // CatBot();

            // Console.WriteLine("");

            //CAT DELEGATE - More efficient using methods
            catDele CatBot = new catDele(C1.sayMeow);
            updateCatBot(C1, CatBot);

            Console.WriteLine("Setting up the next cat...");
            Thread.Sleep(3000);

            updateCatBot(C2, CatBot);
            


            //NUMBER CHECKER DELEGATE
            numberCheckDele checkerBot = new numberCheckDele(isEven);
            checkerBot+=isPositive;//reminder not calling method only referencing it
            checkerBot+=isDivisbleByThree;
            Console.WriteLine(checkerBot(21));


            //INTRO thread.sleep
            Console.WriteLine("Hi there");
            Thread.Sleep(1500);//waits 1500 miliseconds before next line
            Console.WriteLine("My name is Computer");
            
            Console.WriteLine("");

            Random r = new Random();
            int someNum = r.Next(1000, 5000);
            Console.WriteLine("Waiting {0} seconds",someNum/1000);
            Thread.Sleep(someNum);
            Console.WriteLine("Wait complete!");


            //FUNCTIONS 
            //portable filing cabinet
            Func <int, bool> numberCheckFunc = isEven;//int bool are the parameters of methods being associated
            numberCheckFunc += isDivisbleByThree;
            numberCheckFunc(2);

            //ACTIONS 
            //always have void returns
            Action<string> greeterAction = sayHello;
            greeterAction +=sayBye;
            greeterAction("Alexia");

        }//main
    }//class
}//namespace
