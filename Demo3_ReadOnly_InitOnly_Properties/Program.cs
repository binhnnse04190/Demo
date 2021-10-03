using System;

namespace Demo3_ReadOnly_InitOnly_Properties
{
    class MyClass
    {
        // Init-only properties
        public int x { get; init; }
        // Read-only properties
        public int y { get; }

        public MyClass()
        {
            x = 10;
            y = 20;
        }
        public MyClass(int a, int b)
        {
            x = a;
            y = b;
        }
    }
    class Program
    {
        static void Main(string[] args)
        {
            // Use Init-only properties
            MyClass obj1 = new MyClass { x = 1 };
            Console.WriteLine($"x = {obj1.x}, y = {obj1.y}");
            //obj1.x = 3; // Error
            //obj1.y = 4; // Error
            MyClass obj2 = new MyClass();
            Console.WriteLine($"x = {obj2.x}, y = {obj2.y}");
            MyClass obj3 = new MyClass(15, 25);
            Console.WriteLine($"x = {obj3.x}, y = {obj3.y}");
        }
    }
}
