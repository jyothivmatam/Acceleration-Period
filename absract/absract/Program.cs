using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace absract
{
    internal class Program
    {
        static void Main(string[] args)
        {
            MathPro mathpro=new MathPro();
            Math math =mathpro;
            math.Add(5, 10);
            math.Sub(60, 50);
            math.Div(5,10);
            math.Mul(60,10);

        }
    }
}
