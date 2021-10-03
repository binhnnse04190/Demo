using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Demo1_Classes_Objects
{
    class Car
    {
        public string Make;
        public string Model;
        public void Driving()
        {
            Console.WriteLine("Driving");
        }
        public void Accelerating()
        {
            Console.WriteLine("Accelerating");
        }
        public void Braking()
        {
            Console.WriteLine("Braking");
        }
    }
}
