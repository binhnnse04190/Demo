using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Demo4_Inheritance
{
    public class Manager : Employee
    {
        private string email;

        public Manager(int id, string name, string email) : base(id, name)
        {
            this.Email = email;
        }

        public string Email { get => email; set => email = value; }

        public override string ToString()
        {
            return $"Id: {Id}, Name: {Name}, Email: {email}";
        }
    }
}