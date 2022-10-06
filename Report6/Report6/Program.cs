using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static Report6.Rectangle;
using static Report6.Rectangle.Circle;
using static Report6.Rectangle.Circle.Triangle;
using static Report6.Rectangle.Circle.Triangle.Cone;

namespace Report6
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Rectangle rect = new Rectangle(10, 20);
            Console.WriteLine("The area of Rectangle is " + rect.GetArea());

            Circle cir = new Circle(20);
            Console.WriteLine("The area of Circle is " + cir.GetArea());
           
                
            Triangle tria = new Triangle(10, 30);
            Console.WriteLine("The area of triangle is " +tria.GetArea());

            Cone co = new Cone(20, 10);
            Console.WriteLine("The area of Cone is " +co.GetArea());

            Square sq = new Square(10);
            Console.WriteLine("The area of Square is " +sq.GetArea());  



        }
    }
}
