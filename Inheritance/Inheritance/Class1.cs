using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;

namespace Inheritance
{
    class RegularPolygon
    {
        public  void CalucalatePerimeter(int length, int sides)
        {
            int result = length * sides;
            Console.WriteLine("The perimeter is " + result);

        }
    }


    class Square : RegularPolygon
    {
        public int length = 300;
        public int sides = 4;
        public void CalucalateArea()
        {
            int area = length * length;
            Console.WriteLine("The area of square is " + area);
        }
    }
    class Rectangle : RegularPolygon
    {
        public int length = 200;
        public int breadth = 300;
        public int sides = 4;
        public void CalucalateArea()
        {
            int area = length * breadth;
            Console.WriteLine("The area of Rectangle is " + area);

        }
    }
    class Triangle : RegularPolygon
    {
        public int length = 80;
        public int height = 60;
        public int sides = 3;
        public void CalucalateArea()
        {
            double area = 0.5 * length * height;
            Console.WriteLine("The area of triangle is " + area);
        }

    }
}
    
    

