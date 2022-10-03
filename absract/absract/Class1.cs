using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace absract
{
   public abstract class Math
    {
        public void Add(int x,int y)
        {
            Console.WriteLine($"Addition of {x} and {y} is {x + y}");

        }
        public void Sub(int x, int y)
            {
                Console.WriteLine($"Subtraction of {x} and {y} is : {x - y}");
            }
        public abstract void Mul(int x, int y);
          public abstract void Div(int x, int y);
        }
        public class MathPro : Math
        {
            public override void Mul(int x, int y)
            {
                Console.WriteLine($"Multiplication of {x} and {y} is : {x * y}");
            }
            public override void Div(int x, int y)
            {
                Console.WriteLine($"Division of {x} and {y} is : {x / y}");
            }
            public void Mod(int x, int y)
            {
                Console.WriteLine($"Modulos of {x} and {y} is : {x % y}");
            }
        }

    }

