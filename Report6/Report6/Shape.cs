using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;

namespace Report6
{
   public  abstract class Shape
    {
        public double Height;
        public double Width;
        public double Radius;
        public const float PI = 3.14f;
        public abstract double GetArea();

    }
    public class Rectangle : Shape
    {
        public Rectangle(double Height,double Width)
        {
            this.Height = Height;
            this.Width = Width;
        }
        public override double GetArea()
        {
            return Height * Width;
        }
    public class Circle : Shape
        {
            public Circle(double Radius)
            {
                this.Radius = Radius;

            }
            public override double GetArea()
            {
                return PI * Radius * Radius;
            }
    public class Triangle : Shape
            {
               public Triangle(double Height,double Width)
                {
                    this.Width=Width;
                    this.Height=Height;
                }
                public override double GetArea()
                {
                    return Height * Width / 2;
                }
    public class Cone : Shape
                {
                    public Cone(double Radius , double Height)
                    {
                        this.Radius=Radius;
                        this.Height=Height;
                    }
                    public override double GetArea()
                    {
                        return PI * Radius*(Math.Sqrt((Radius * Radius) + (Height * Height)));
                    }
    public class Square : Shape
                    {
                        public Square(double Width)
                        {
                            this.Width = Width;
                        }
                        public override double GetArea()
                        {
                            return Width * Width;
                        }
                    }
                }

            }
        }
    }
}
