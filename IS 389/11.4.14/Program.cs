//week 10 - 11/4/24

//override and virtual

Appliances A1 = new Appliances();
Television T1 = new Television();
A1.details();
T1.details();

class Appliances
{
    static int nextID = 1;
    int applianceID;
    public Appliances()
    {
        applianceID = nextID++; //++nextID; would increment first and then set it equal to
        // nextID++; - is on the line before
    }
    public  virtual void details()
    {
        Console.WriteLine($"ID: {applianceID}");
    }
}//parent - app

class Television: Appliances
{
    double screenSize;
    public Television() :base()
    {
        screenSize = 24.5;
    }
    public Television(int screenSize) :base()
    {
        this.screenSize = screenSize;
    }
    public override void details()
    {
        base.details(); //calls virtual method
        Console.WriteLine($"TV screensize: {screenSize}");
    }
}//child - tele