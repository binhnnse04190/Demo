using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Demo4_Inheritance_TínhKeThua
{
    //Parent Class (class cha)
    class Employee
    {
        public int id { get; set; }
        public string Name { get; set; }

        public Employee(int id, string name)
        {
            this.id = id;
            Name = name;
        }
    }
}
