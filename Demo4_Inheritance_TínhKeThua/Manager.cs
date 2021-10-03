using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Demo4_Inheritance_TínhKeThua
{
    //Chil class (class con)
    class Manager : Employee
    {
        //New Property
        public Manager(string email, int Id, string name) : base(Id, name)
        {
            Email = email;
           
        }
        //New Method

        public string Email { get; set; }
        //Lớp con bắt buộc phải khai báo toString để ghi đè thuộc tính lớp cha
        public override string ToString()
        {
            return $"ID: {id}, Name : {Name}, Email: {Email}";
        }
    }
}
