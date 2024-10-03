//week 6 - 9.30.24

namespace Week6
{
    class Week6
    {
        delegate void smallTalkDele(string n);//filing cabinet - teh cabinets are the methods
        delegate int mathDele(int num1, int num2);
        
        public static void Main(string[]args)
        {
            Console.WriteLine("\n\n\n\n\n\n");
            Donut D1 = new Donut();
            Donut D2 = new Donut();

            D2.name = "Chocolate Donut";
            D2.toppings.Add("Chocolate Icing", 1);

            D1.toppings.Add("Sprinkles", .50);
            D1.updatePrice();
            D2.updatePrice();
            D1.displayDonut();
            D2.displayDonut();

            //delegate intro
            smallTalkDele chatBot1 = new smallTalkDele(sayHello); //name of the method not a call to the method //chatbot one is the filing cabinet
            chatBot1+=doSmallTalk;
            chatBot1+=sayBye;//name of the method not a call to the method
            
            //multio casting delegagte
            chatBot1("Alexia");//will open both the sayhello and saybye drawers of the filing cabinet

            // sayHello("Alexia");
            // sayBye("Alexia");

            //ex:
            //weather
            //three delegates, rain, snow, clear skies
            //rain, snow, clear
            //additional considerations after determining weather

            Random r = new Random();
            headsOrTails(r);
            randomNumber(r,1,10);

            // mathDele mathBot = new mathDele(addition);
            // mathBot += subtraction;
            // Console.WriteLine(mathBot(10,15));

            mathDele [] mathBot = {addition, subtraction, multiplication};
            //Console.WriteLine(mathBot[0](10,20));
            
            Console.WriteLine("Enter two numbers:");
            int uNum1 = Convert.ToInt32(Console.ReadLine());
            int uNum2 = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine(mathBot[r.Next(0, mathBot.Length)](uNum1,uNum2));

            
        }//main

        //addition method
        static int addition(int num1, int num2)
        {
            return num1 + num2;
        }

        //subtraction method
        static int subtraction(int num1, int num2)
        {
            return num1 - num2;
        }

        static int multiplication(int num1, int num2)
        {
            return num1 * num2;
        }

        //heads or tails
        //outputs heads or tails, 50 50 chance
        static void headsOrTails(Random r)
        {
            if(r.Next(0,2)==0)
                Console.WriteLine("heads");
            else
                Console.WriteLine("tails");


        }

        //randomNumber progream
        //outputs a random number based in a range
        static void randomNumber(Random r,int lower, int upper)
        {
            Console.WriteLine(r.Next(lower,upper+1));
        }

        static void sayHello(string n)
        {
            Console.WriteLine("Hello {0}! :)",n);
        }//say hello method
        static void sayBye(string n)
        {
            Console.WriteLine("Bye {0}! :(",n);
        }//say bye method

        static void doSmallTalk(string n)
        {
            //randomly says a line of small talk to the user
            Random r = new Random();
            switch(r.Next(0,3))
            {
                case 0:
                Console.WriteLine("Nice day, huh {0}?",n);
                break;
                case 1:
                Console.WriteLine("How are you {0}?",n);
                break;
                case 2:
                Console.WriteLine("How's it going {0}?",n);
                break;
                default:
                Console.WriteLine("Nice weather we are having right {0}? ", n);
                break;
            }//switch case
        }//dosmalltalk method
    }//week6 class

     class Donut
    {
        static double BasePrice = 1.99; //raw donut is $1 to calculate along with toppings
        double price;
        public string name;
        public Dictionary<string, double> toppings = new Dictionary<string, double>();
        public Donut()
        {
            name = "Old Fashioned";
            toppings.Add("Sugar Glaze",1.50);
            this.updatePrice();
        }//default constructor
        //create two instance methods
        //donut display
        public void displayDonut()
        {
            Console.WriteLine("{0} costs ${1} and has the following toppings:",name, price);
            foreach(string item in toppings.Keys)
                Console.WriteLine("-{0}",item);   

                Console.WriteLine("");        

        }
        //donut price update
        public void updatePrice()
        {
            //link together the base price to the starting price of the donut
            price = Donut.BasePrice;
            foreach(KeyValuePair<string, double> kvp in toppings)
            {
                price+= kvp.Value;//add topping prices 
            }
                
        }//updatePrice method
    }//donut class
}//namespace
