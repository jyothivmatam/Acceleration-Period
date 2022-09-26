
/*
 * Type Casting-implicit(smaller datatypes to larger data type)
 * explicit-(larger datatypes to smaller data type)
 * ex: 1.int n=100;
 * double d=n;(converting int to double-implicit)
 *2. double d=60.357
 *int n=(int)d (converting double to int-explicit)
 *3. int n=20;
 *byte b=(int)b; (converted int to byte-explicit)
 *4.string str="200";
 *int num=Convert.ToInt32(str); (str to int)
 *5.float f=2.56f;
 *string str=Convert.ToString(f);
 *6.double n1=9.34;
 *int d=convert.ToInt32(n1);

 *Type conversion using parse method
 *string s="500";
 *int n2=int.Parse(s); (converting string to int)
 *string s="false";
 *bool b=bool.Parse(s);  (converting string to bool)
 *variaables:
 
 *static and non static variables
 *static int x = 100; //Static Variable
        int y = 200; //Non-Static or Instance Variable  */

using System;

using systemusing System.Runtime.InteropServices;
{
    namespace Demo {
    class Program {
        int x = 100;
            static int y = 200;
        static void Main(string[] args)
        {
            Console.WriteLine($"x value: {x}");
            Program obj1 = new Program();
            Program obj2 = new Program();
            Console.WriteLine($"obj1 y value: {obj1.y}");
            Console.WriteLine($"obj2 y value: {obj2.y}");
        }
    }
}
            // initializing non static variables through constructor method
            
            static int x = 100; //Static Variable
            int y = 200; //Non-Static or Instance Variable
                         //Class Constructor
            public Program(int a)
            {
                y = a; //Initializing non-static variable
                x = a; //Initializing static variable
            }
            static void Main(string[] args)
            {
                Console.WriteLine($"x value: {x}"); //x = 100
                Program obj1 = new Program(300);
                Console.WriteLine($"obj1 y value: {obj1.y}");
                Console.WriteLine($"x value: {x}"); //x = 300
                Program obj2 = new Program(400);
                Console.WriteLine($"obj2 y value: {obj2.y}");
                Console.WriteLine($"x value: {x}"); //x = 400
                Console.Read();
}
        }
    }


/* Difference btw instance and static variable
 * if we are initializing the static variables through constructors,then for each constructor execution,it will override the execution values of a ststic variable.
 *  the case of Instance Variable, each object will have its own copy whereas We can only have one copy of a static variable irrespective of how many objects we create.
In C#, the Changes made to the instance variable using one object will not be reflected in other objects as each object has its own copy of the instance variable. 
In the case of static variables, changes made in one object will be reflected in other objects as static variables are common to all objects of a class.
We can access the instance variables through object references whereas the Static Variables can be accessed directly by using the class name in C#.

Scope of instance variable-through out the class except in static method;
scope of the static variable-through out the class;

Constant variable:the variable value does not change after the decalaration.
ex: const float PI=3.14f.

Readonly variables:we can intialize the readonly variables by constructor method.*/
using System;
namespace TypesOfVariables
{
    internal class Program
    {
        const float PI = 3.14f; //Constant Variable
        static int x = 100; //Static Variable
        //We are going to initialize variable y through constructor
        int y; //Non-Static or Instance Variable
        readonly int z; //Readonly Variable
        //Constructor
        public Program(int a, int b)
        {
            //Initializing non-static variable
            y = a;
            //Initializing Readonly variable
            z = b;
        }
        static void Main(string[] args)
        {
            //Accessing the static variable without instance
            Console.WriteLine($"x value: {x}");
            //Accessing the constant variable without instance
            Console.WriteLine($"PI value: {PI}");
            Program obj1 = new Program(300, 45);
            Program obj2 = new Program(400, 55);
            //Accessing Non-Static variable using instance
            Console.WriteLine($"obj1 y value: {obj1.y} and Readonly z value: {obj1.z}");
            Console.WriteLine($"obj2 y value: {obj2.y} and Readonly z value: {obj2.z}");
            Console.Read();
        }
    }
}




/*Local Variable:these variables are declared inside the method of a class.The scope of the variable is limited to that method only.

Operators:Bit wise operators-bit wise OR,bitWise AND,bitWise XOR.
EX; int a,b;
a | b, a & b,a ^ b respectively.

Unary operators:it operates on a single operand in which two types
these are Post increment,pre increment(a++,++a)

Ternary Operator:it operates on three operands
ex; (a>b?a:b)
 
Control flow statements:these are the statements they alter the flow of program execution.and provides better control to the programmer.
Console.ReadKey();

Condition Statements:
if, if else,switch  */

int n;
if (n < 0)
{
    Console.WriteLine("negative");
}

//for if else
int n;
if (n < 0)
{
    Console.WriteLine("negative");
}
else
    Console.WriteLine("positive");
Console.ReadKey();

//nested if using ternary

int a = 15, b = 25, c = 10;
int LargestNumber = 0;
Console.WriteLine($"a={a}, b={b}, c={c}");
LargestNumber = (a > b) ? ((a > c) ? (a) : (c)) : ((b > c) ? (b) : (c));
Console.WriteLine($"The Largest Number is: {LargestNumber}");

// switch statement

string str = "C#2";
Console.WriteLine("Switch Statement Started");
switch (str)
{
    case "C#":
    case "Java":
    case "C":
        Console.WriteLine("It's a Programming Language");
        break;
    case "MSSQL":
    case "MySQL":
    case "Oracle":
        Console.WriteLine("It's a Database");
        break;
    case "MVC":
    case "WEB API":
        Console.WriteLine("It's a Framework");
        break;
        // we use switch statements over if else statements because if-else used only for smaller number of logical evaluation of value.
        // but nested switch statements make the code more complex and less readable.

        /* looping: execution of set of instructions repeatedly
         * in this do while, while and for loop is there.*/

        //for loop

        for (int i = 0; i <= 10; i++)

            //while

            int n = 0;
        while (n > 5)
        {
            Console.WriteLine(n);
            n++;
        }









