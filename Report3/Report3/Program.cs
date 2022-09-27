//Functions
// it is a group of instructions that performs a sprcific task.
//Functions take some input as parameters and return the result as a return value.
//Two types of functions,Built in,User-defined functions
//Built in Function examples
using System.Reflection.Metadata;
using System.Reflection.Metadata.Ecma335;

int number = 25;
double squareRoot = Math.Sqrt(number);

//User Defined Functions:
User defined functions are created by programmers,so they can use it many times it reduces the complexity of a big program and it optimizes the code.
code reusability-we can use the code whrever we want.

    //syntax for creating function
  //  <Access Modifiers>[Modifier]<Return type><Function name>[parameter List]
  {
    Function Body
    }
    Ex;

public int MaxNumber(int m,int n)
{
    if (n > m)
        return true;
    else
        return false;
}

class Program
{
    static void Main(string[] args)
    {
        int x, y;
        x = 10;
        y = 15;
        int sum = Add(10, 20);
        Console.WriteLine($"Sum is {sum}");
        Console.ReadKey();
    }
    static int Add(int a, int b)
    {
        int sum = a + b;
        return sum;
    }
}
/* In user Defined Function there are four types.
 * 1.Functions with No Argument and No Return Type.
2.Functions with Argument and No Return Type.
3.Functions with No Argument and with Return Type.
4.Functions with Argument and with Return Type */

//Example of Function with No Argument and No Return Type.

class Program
{
    static void Main(string[] args)
    {
        Sum();
        Console.ReadKey();
    }
    static void Sum()
    {
        int x = 10;
        int y = 20;
        int sum = x + y;
        Console.WriteLine($"Sum of {x} and {y} is {sum}");
    }
}

//2. Functions with Argument and No Return Type.When a function has no arguments, it does not receive any data from the calling function, but it returns a value, the calling function receives the data from the called function. 

class Program
{
    static void Main(string[] args)
    {
        int Result = Sum();
        Console.WriteLine($"Sum is {Result}");
        Console.ReadKey();
    }
    static int Sum()
    {
        int x = 10;
        int y = 20;
        int sum = x + y;
        return sum;
    }
}
//Argument Passed but No return value

class Program
{
    static void Main(string[] args)
    {
        int x = 10, y = 20;
        Sum(x, y);
        Console.ReadKey();
    }
    static void Sum(int x, int y)
    {
        int sum = x + y;
        Console.WriteLine($"Sum is {sum}");
    }
}

// Argument passed and return value also there

class Program
{
    static void Main(string[] args)
    {
        int x = 10, y = 20;
        int Result = Sum(x, y);
        Console.WriteLine($"Sum is {Result}");
        Console.ReadKey();
    }
    static int Sum(int x, int y)
    {
        int sum = x + y;
        return sum;
    }
}

// Function overloading:
// it has more than one functions with the same name but different signatures like no of parameters,type of parameters.
//Example for this

class Program
{
    static void Main(string[] args)
    {
        int x = 10, y = 20, z, z1;
        z = Add(x, y);
        Console.WriteLine($"The sum is:{z}");
        z1 = Add(x, y, z);
        Console.WriteLine($"The sum is:{z1}");
        Console.ReadKey();
    }
        static int Add(int a, int b)
        {
            return a + b;
        }
        static int Add(int a,int b,int c)
        {
            return a+b+c;
        }

}

//Call By value

class program
{
    static void Main(string[] args)
    {
        int a = 15;
        UpdateValue(a);
        Console.WriteLine(a);
        Console.ReadKey();
    }

    private static void UpdateValue(int b)
    {
        b = 0;
    }
}

//call by reference
class Program
{
    static void Main(string[] args)
    {
        Employee Emp1 = new Employee();
        Emp1.EmployeeID = 1001;
        Emp1.Name = "James";
        UpdateName(Emp1);
        Console.WriteLine($"Emp1 Name = {Emp1.Name}");
        Console.ReadKey();
    }
    public static void UpdateName(Employee Emp2)
    {
        Emp2.Name = "Smith";
        Console.WriteLine($"Emp2 Name = {Emp2.Name}");
    }
}
    public class Employee
    {
        public int EmployeeID;
        public string Name;
    }

//call by reference by using ref Keyword
class Program
{
    static void Main(String[] args)
    {
        Employee Emp1 = new Employee();
        Emp1.EmployeeID = 1001;
        Emp1.Name = "James";
        UpdateName( ref Emp1);
        Console.WriteLine($"Emp1 Name = {Emp1.Name}");
        Console.ReadKey();
        public static void UpdateName(ref Employee Emp2)
        {
            Emp2 = null;
        }
    }
    public class Employee
    {
        public int EmployeeID;
        public string Name;
    }
}
//Recursion
//In order to solve a problem recursively, two conditions must be satisfied. First, the problem must be written in a recursive form so that the function will call itself, and second, 
    //the problem statement must include a stopping condition so that we can stop the function call.

