using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Company1
{
  class program
    {

        static void Main(string[] args)
        {
            Company company = new Company();

            company.Id = 123;
            company.name="Moback";
            company.address="Bangalore";
            company.scale=100;
            Console.WriteLine(company.Id);
            Console.WriteLine(company.name);
            Console.WriteLine(company.address);
            Console.WriteLine(company.scale);
            company.Gettype();
            company.GetTechnologies();
            Console.ReadLine();

        }
    }
}
