using System;

namespace Demo10_Anonymous_Type
{
    class Program
    {
        static void Main(string[] args)
        {
            var obj1 = new { id = 1000, name = "Chau" };
            dynamic obj2 = new { id = 2000, name = "Hung", email = "hung@gmail.com" };

            Console.WriteLine($"Id: {obj1.id}, Name: {obj1.name}");
            Console.WriteLine($"Id: {obj2.id}, Name: {obj2.name}, Email: {obj2.email}");

            Console.ReadLine();
        }
    }
}
