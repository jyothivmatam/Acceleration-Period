using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Company1
{

    class Company
    {
        private int ID;
        private string Name;
        private string Address;
        private int Scale;


        public Company()
        {
            Console.WriteLine("good company");
        }
        public int Id { get { return ID; } set { ID = value; } }
        
            
        
        public string name { get { return Name; } set { Name = value; } }
        
           
        
        public string address { get { return Address; } set { Address = value; } }
        
  
        public int scale { get { return Scale; } set { Scale = value; } }
        
          
        
        public void Gettype()
        {
            Console.WriteLine("Service Based Company");

        }
        public void GetTechnologies()
        {
            Console.WriteLine("C Sharp");
            Console.WriteLine("Dot Net");
            Console.WriteLine("Azure");
        }
    }
}




