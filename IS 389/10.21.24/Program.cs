//week 8 - 10.21.24

//to create an event you need at least 2 classes
//similar to delegates (a type)
//events notify programs when something occurs

namespace Week8
{
    //create a delegate for the event
    delegate void KidDelegate(string action);//delegate templete for the event
    delegate void PichtcherDelegate(Pitcher P);//pitcher??? as a parameter?

    class Week8
    {
        public static void Main (string[]arg)
        {
                //create publishing class object
                Kid K1 = new Kid();
                K1.name = "Calvin";

                Kid K2 = new Kid();
                K2.name = "Suzie";
                

                Babysitter B1 = new Babysitter("Rosyln");
                Babysitter B2 = new Babysitter("Hobbes");

                //subscribe method to the publishing class event
                K1.KidEvent += B1.onYell;
                K1.yell();//calling the method invokes the event

                Console.WriteLine("");

                K2.KidEvent += B1.onYell;
                K2.KidEvent += B2.onYell;
                K2.yell();

                Console.WriteLine("");

                //pitching
                Pitcher P1 = new Pitcher();
                Pitcher P2 = new Pitcher();

                P2.name = "Zoe";
                P2.pitches.Add("knuckle drop");
                P2.pitches.Add("screwball");

                Batter BB1 = new Batter("Alexia");
                P1.PitchEvent += BB1.onPitch;
                P1.pitch();

                Console.WriteLine("");

                P2.PitchEvent += BB1.onPitch;
                P2.pitch();

        }//main
    }//week8 class

    class Batter
    {
        string name;
        List<string> hittablePitches = new List<string>();
        public Batter(string name)
        {
            this.name = name;
            hittablePitches.Add("fastballs");
        }//constructor
        //subscription method
        public void onPitch(Pitcher pPitcher)//passes the entire object so anything in it can be used
        {
            Random r = new Random();
            string pitchThrown = pPitcher.pitches[r.Next(pPitcher.pitches.Count)];
            //Console.WriteLine("{0} sees {1} throw the ball!", this.name, pPitcher.name);
            //instead of "throw the ball" display one of the avaliable pPitchers pitches
            Console.WriteLine("{0} sees {1} throw a {2}!", this.name, pPitcher.name, pitchThrown);

            //give batter an option to hit
            //check to see if the pitch is one of the hittable ones
            if(this.hittablePitches.Contains(pitchThrown))
                Console.WriteLine("\t{0} hits the {0} :)", this.name, pitchThrown);
            else
                Console.WriteLine("\t{0} swings and misses the {1} :(",this.name, pitchThrown);
        }//on pitch
    }//batter class
    class Pitcher
    {
        //publishing
        public string name;
        public List<string> pitches;

        public event PichtcherDelegate PitchEvent;
        public Pitcher()
        {
            name = "Sarah";
            pitches = new List<string>{"fastball", "curveball"};
        }//default constructor

        public void pitch()
        {
            PitchEvent.Invoke(this);//wdym this?
        }
    }
    class Babysitter//subscriber class
    {
        string name;//1
        public Babysitter(string name)//2
        {
            this.name = name;//this - class level variable//1 , name without the is paramter name //2
        }//constructor
        public void onYell(string yellingKid)//on whatever publisher method is named
        {
            Console.WriteLine("{0} hears {1} yelling!", this.name, yellingKid);

        }
    }//babysitter class
    class Kid//publishing class
    {
        public string name;//instance variable - non static each object has its own name
        //event is created her in publishing class
        public event KidDelegate KidEvent;//instance event
        public void yell()//instance method
        {
            Console.WriteLine("{0} yells!",this.name);
            KidEvent.Invoke(this.name);
        }
    }//kid class
}//namspace
