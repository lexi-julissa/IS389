//week 6 - 10.2.24

using System.Runtime.InteropServices;

namespace Week6
{
    class Week6
    {
        delegate void weatherCheckerDele(Random r);
        static void Main(string[] args)
        {
            Random r = new Random();

            string weatherType = "";
            if(r.Next(0,3)==0)
                weatherType = "Sunny";
            else if(r.Next(0,3)==1)
                weatherType = "Snowy";
            else
                weatherType = "Rainy";

            Console.WriteLine($"The weather today is: {weatherType}");


            weatherCheckerDele checker = new weatherCheckerDele(tempDisplay);

            switch (weatherType)
            {
                case "Sunny":
                    checker += uvDisplay;
                    break;
                case "Snowy":
                    checker += snowfallDisplay;
                    break;
                case "Rainy":
                    checker += rainfallDisplay;
                    break;
            }//SWITCH CASE

            checker(r);

        }//main
        static void tempDisplay(Random r)
        {
            Console.WriteLine("{0} degrees F",r.Next(20,101));
        }//tempDisplay method

        static void uvDisplay(Random r)
        {
            if(r.Next(0,3)==1)
                Console.WriteLine("low UV");
            else if(r.Next(0,3)==2)
                Console.WriteLine("medium UV");
            else
                Console.WriteLine("high UV");
        }//uvDisplay method
        static void snowfallDisplay(Random r)
        {
            if(r.Next(0,3)==1)
                Console.WriteLine("light snowfall");
            else if(r.Next(0,3)==2)
                Console.WriteLine("medium snowfall");
            else
                Console.WriteLine("heavy snowfall");
        }//snowfallDisplay method
        static void rainfallDisplay(Random r)
        {
            if(r.Next(0,2)==0)
                Console.WriteLine("light rainfall");
            else
                Console.WriteLine("heavy rainfall");
        }//rainfallDisplay method

    }//week 6 class
}//namespace