//week 9 - 10.28.24

//static variables belong to the class
//non static variables - instance variables referenced through the class
using System.Runtime.Intrinsics.X86;

namespace Week9
{
    class Week9
    {
        public static void Main (string[]arg)
        {
            Animal A1 = new Animal("Pookie", 5);
            Animal A2 = new Animal("Snoopy", 6);
            Animal A3 = new Animal();

            Cat C1 = new Cat();

            A1.eat();
            A1.animalInfo();
            A2.animalInfo();
            A3.animalInfo();

            C1.animalInfo();//child can use parent methods
            C1.meow();
            //A1.meow();//parent can not use child methods this way
        }//main
    }//week9 class

    public class Animal
    {
        public string name;
        int age;
        int animalID;
        static int nextIDValue = 1;
        public Animal() : this("Default animal", -1)
        {
            // name = "Default animal";
            // age = -1;
        }
        public Animal (string name, int age)//what is this again
        {
            this.name = name;
            this.age = age;
            // this.animalID = Animal.nextIDValue;
            // nextIDValue++;
            setAnimalID(this);//this will be associated the Animal?
        }
        //setAnimalID static void animal parameter
        public static void setAnimalID(Animal pAnimal)
        {
            pAnimal.animalID =Animal.nextIDValue;
            nextIDValue++;
        }
        public void eat()//non static method
        {
            Console.WriteLine("{0} eats food!", this.name);
        }
        public void animalInfo()//non static method
        {
            Console.WriteLine("{0} is {1} year(s) old. Animal ID: {2}", this.name, this.age, this.animalID);
        }
    }//animal class - parent class

    class Cat: Animal
    {
        public void meow()
        {
            Console.WriteLine("{0} meows!", this.name);
        }
    }//cat class - child class - parent is animal
}//namespace
