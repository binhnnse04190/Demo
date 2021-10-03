using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Demo4_Inheritance
{
    public class Employee
    {
        private int id;
        private string name;

        //public Employee(int id, string name)
        //{
        //    this.Id = id;
        //    this.Name = name;
        //}

        public Employee(int id, string name) => (Id, Name) = (id, name);

        public int Id { get => id; set => id = value; }
        public string Name { get => name; set => name = value; }
    }
}