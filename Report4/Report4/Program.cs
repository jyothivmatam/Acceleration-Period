/*OOPS:

Object - Oriented Programming is a strategy that provides some principles for developing applications or developing software. 
    It is a methodology.
all most all the latest programming languages support object orientation and this object orientation is more related to the designing of software and this deals with the internal design of the software, not the external design

OOPS Concepts:
Encapsulation
Inheritance
Polymorphism
Abstraction

Abstraction:
The process of representing the essential features without including the background details is called Abstraction.

Encapsulation:
The process of binding the data and functions together into a single unit (i.e. class) is called Encapsulation.

Inheitance:
The process by which the members of one class are transferred to another class is called inheritance.

Polymorphisim:
The process of object can take multiple forms.

Class:
A class is simply a user-defined data type that represents both state and behavior.
The state represents the properties and behavior is the action that objects can perform. In other words, we can say that a class is the blueprint/plan/template that describes the details of an object.
A class is a blueprint from which the individual objects are created. In C#, a Class is composed of three things i.e. a name, attributes, and operations.

Object:
It is an instance of a class. A class is brought live by creating objects. An object can be considered as a thing that can perform activities. 
The set of activities that the object performs defines the object’s behavior */

using System;
namespace Program
{
    class Employee
    {
        public int EmployeeID;
        public string EmployeeName;
        public int EmployeeSalary;
    }

    static void Main(string[] args)
    {
        Employee employee = new Employee();
        employee.EmployeeID = 121;
        employee.EmployeeName = "kenny";
        employee.EmployeeSalary = 40000;

    }
}

/*Constructor:
It is a special method present inside a class responsible for initializing the variables of that class
The name of the constructor method is exactly the same name as the class in which it was present.
It can have all five accessibility modifiers i.e. public, private, protected, etc.
The constructor can be parameterless or parameterized.
It can have a throws clause which means we can throw an exception from the constructor.  */


class Car
{
  public string model;  

  
  public Car()
  {
    model = "Mustang"; 
  }

    static void Main(string[] args)
    {
        Car Ford = new Car();
        Console.WriteLine(Ford.model);
    }
}


/*  Access Modifiers:
 *  public-	The code is accessible for all classes
private- The code is only accessible within the same class
protected-	The code is accessible within the same class, or in a class that is inherited from that class.
internal - The code is only accessible within its own assembly, but not from another assembly. */

//Inheritance Example

class Vehicle  
{
  public string brand = "Duke";  
  public void honk()            
  {                    
    Console.WriteLine("Tuut, tuut!");
  }
}
class Bike : Vehicle 
{
  public string modelName = "Pulsar";  
}

class Program
{
  static void Main(string[] args)
  {
   Bike myBike = new Bike();
      myBike.honk();
   Console.WriteLine(myBike.brand + " " + myBike.modelName);
  }
}
/*Structures:
a structure is a value type data type. It helps you to make a single variable hold related data of various data types. 
    The struct keyword is used for creating a structure.*/

struct Books
{
    public string title;
    public string author;
    public string subject;
    public int book_id;
};


/*class versus Structure
 classes are reference types and structs are value types
structures do not support inheritance
structures cannot have default constructor  */