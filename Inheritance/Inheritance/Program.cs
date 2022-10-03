using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Configuration;


namespace Inheritance
{
    internal class Program
    {
        static void Main(string[] args)
        {
           
            Square s1=new Square();
            s1.CalucalateArea();
            s1.CalucalatePerimeter( s1.length, s1.sides);

            Rectangle r1=new Rectangle();
            r1.CalucalateArea();
            r1.CalucalatePerimeter( r1.length, r1.sides);

            Triangle triangle=new Triangle();
            triangle.CalucalateArea();
            triangle.CalucalatePerimeter( triangle.length, triangle.sides);

        }
    }
}
