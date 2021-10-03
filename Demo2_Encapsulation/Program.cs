using System;

namespace Demo2_Encapsulation
{
    class Customer
    {
        private int id;
        // Full properties
        public int Id { get => id; set => id = value; }
        // Automatic properties
        public string Name { set; get; } = "New customer";
        public void PrintCustomer()
        {
            Console.WriteLine($"ID: {Id}, Name: {Name}");
        }
    }
    class Program
    {
        static void Main(string[] args)
        {
            Customer customer = new Customer();
            customer.Id = 1000;
            Console.WriteLine($"ID: {customer.Id}, Name: {customer.Name}");
            customer.Id = 2000;
            customer.Name = "David";
            customer.PrintCustomer();
        }
    }
}
