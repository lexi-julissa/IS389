// Class notes for 8.28.24

//Console.WriteLine("Hello, World!");
//console class, writeline method "string" --- what will be displayed ;seperates code

//ERRORS

//SYTAX ERROR
//console.WriteLine(""); //Capital C needed to fix

// RUNTIME ERROR
// Console.WriteLine("Please type a number");
// int x = Convert.ToInt32(Console.ReadLine());
// Console.WriteLine(4 / x);

// //Logical ERROR
// Console.WriteLine("Please type the length and width of a rectangle"); //prompt
// int length = Convert.ToInt32(Console.ReadLine()); //declaration of variables, set by user
// int width = Convert.ToInt32(Console.ReadLine()); //declaration of variables, set by user
// int area = length * width;
// Console.WriteLine("arrea is {0}", x + y); //should be multiples not added
// Console.WriteLine("The area of the rectangle is {0}!", area); // fix    //output based on x and y, set by user input


//Hands on Activity
Console.WriteLine("Please type the radius of a circle"); 
int radius = Convert.ToInt32(Console.ReadLine()); 
double circleArea = 3.14 * radius * radius;
Console.WriteLine("The area of the circle is {0}!", circleArea); 


// sayHello("IS 389!");

//  static void sayHello(string name)
// {
//     Console.WriteLine("Hello " + name);
// }//sayhello method

