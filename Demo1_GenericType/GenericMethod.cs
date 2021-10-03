using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Demo1_GenericType
{
    //Tạo 1 class có 1 generic method
    class MyClass2
    {
        public void Display<T, U>(T param1, U param2)
        {
            Console.WriteLine($"Param 1 = {param1}, Param 2 = {param2}");
        }
    }
    class GenericMethod
    {
        public static void Main(string[] args)
        {
            MyClass2 myClass2 = new MyClass2();
            myClass2.Display<int, string>(1000, "Hello");
            myClass2.Display<double, double>(10.5, 20.5);
        }
    }
}
