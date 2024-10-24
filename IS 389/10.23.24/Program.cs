//weel 8 - ICA pinball

namespace Week8{
    delegate void PinballDele(Player P);//delegate  for the event
    class Week8{
        public static void Main (string[]arg)
        {
            Player P1 = new Player(20);
            Machine M1 = new Machine();
            P1.PinballEvent += M1.onPlay;
            P1.play();
        }//main
    }//class week8
    class Player //publisher
    {
        public int skill;

        public Player(int skill)
        {
            this.skill = skill;
        }

        public event PinballDele PinballEvent;

        public void play()//passes calling player object
        {
            PinballEvent?.Invoke(this);
        }
    }//class player
    class Machine //subscriber
    {
        Dictionary<string, int> features = new Dictionary<string, int>();
        int score;
        public Machine()
        {
            features.Add("bumper", 100);
            features.Add("ramp", 200);
            features.Add("spinner", 300);

            int score = 0;
        }//constructor

        public void onPlay(Player pPlayer)//player parameter
        {
            Random r = new Random();

            int thingHit = 0;
            int roundTotal =0;

            int maxFeatureHits = r.Next(0, pPlayer.skill + 1);//random number of features + 1 so max skill is avaliable

            while(maxFeatureHits != 0)
            {
                maxFeatureHits = r.Next(0, pPlayer.skill + 1);//ineddificent but ok prof

                for (int i = 0; i < maxFeatureHits; i++)
                {
                    thingHit = (r.Next(0, this.features.Count));
                    Console.WriteLine("{0} hit!", this.features.ElementAt(thingHit).Key);
                    roundTotal =+ this.features.ElementAt(thingHit).Value;
                    
                }
                Console.WriteLine("You scored {0} this round", roundTotal);
                score =+ roundTotal;
            }//while
            Console.WriteLine("Ball drained!");
            Console.WriteLine("Final score: {0}", this.score);
        }
    }//class machine
}//namespace week8
