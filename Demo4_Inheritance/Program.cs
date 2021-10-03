using System;

namespace Demo4_Inheritance
{
    class Program
    {
        static void Main(string[] args)
        {
            Manager manager1 = new Manager(1, "John", "john@gmail.com");
            Console.WriteLine(manager1);
            Console.ReadLine();
        }
    }
}
