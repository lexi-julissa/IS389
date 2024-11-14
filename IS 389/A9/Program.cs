//Name: Alexia Cervantes
//Description: Assignment 9 - You have been tasked to create an employee manager with security requirements.

public class Employee
{
    protected internal int SSN;     // Protected internal allows access within assembly and by derived classes
    protected internal string Address; //Protected internal instance string variable Address
    public string Name; //Public instance string variable Name

    // Default constructor
    public Employee()
    {
        SSN = 0;
        Address = "Unknown";
        Name = "Unnamed Employee";
    }

    // parameter constructor
    public Employee(int ssn, string address, string name)
    {
        SSN = ssn;
        Address = address;
        Name = name;
    }
}//employee class
public class Admin : Employee //inherits employee class
{
    private string password; //Private Instance string variable called password

    // Default constructor
    public Admin() : base()  // Calls the Employee default constructor
    {
        password = "default";
    }

    // 4 parameter constructor
    public Admin(int ssn, string address, string name, string adminPassword) : base(ssn, address, name) // Calls the Employee parameter constructor
    {
        password = adminPassword;
    }

    // Method to view employee details if password matches
    public void employeeDetails(Employee employee) //An instance method called employeeDetails() with an employee parameter and void return:
    {
        Console.Write("Enter password: "); //The method will ask for a password
        string enteredPassword = Console.ReadLine();

        if (enteredPassword == password)
        {
            //If the password matches the calling Admin object’s password, 
            //display the name, SSN, and Address of the employee parameter
            Console.WriteLine("Employee Name: {0} :) ", employee.Name);
            Console.WriteLine("Employee SSN: {0}", employee.SSN);
            Console.WriteLine("Employee Address: {0}", employee.Address);
        }
        else
        {
            //If the password is incorrect, inform the user and do not display information
            Console.WriteLine("Incorrect password. Access denied. :(");
        }
    }//employee details method
}//admin class
public class PilotTest
{
    public static void Main(string[] args)//Create a Main method
    {
        // Create Employee objects
        Employee employee1 = new Employee(123456789, "123 Main St", "Mateo");
        Employee employee2 = new Employee(987654321, "456 Oak Ave", "Rufus");

        // Create Admin objects
        Admin admin1 = new Admin(112233445, "789 Pine St", "Orion", "admin123");
        Admin admin2 = new Admin(554433221, "101 Maple Dr", "valentino", "password456");

        // Call the employeeDetails method with each admin for both employees
        Console.WriteLine("Admin 1 attempting to access Employee 1 details:");
        admin1.employeeDetails(employee1);

        Console.WriteLine("\nAdmin 1 attempting to access Employee 2 details:");
        admin1.employeeDetails(employee2);

        Console.WriteLine("\nAdmin 2 attempting to access Employee 1 details:");
        admin2.employeeDetails(employee1);

        Console.WriteLine("\nAdmin 2 attempting to access Employee 2 details:");
        admin2.employeeDetails(employee2);
    }//main
}//pilot test class
