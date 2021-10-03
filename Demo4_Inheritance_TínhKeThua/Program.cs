using System;

namespace Demo4_Inheritance_TínhKeThua
{
    public abstract class Car
    {
        string make;
        string model;

        protected Car(string make, string model)
        {
            this.make = make;
            this.model = model;
        }
    }
    class Program
    {
        static void Main(string[] args)
        {
            Manager manager = new Manager("Bình", 1000, "binh@gmail.com");
            Console.WriteLine(manager);
            Console.ReadLine();
        }
    }
}
