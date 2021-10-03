using System;

namespace Demo5_Polymophism
{
    // Abstract class (parent)
    abstract class Shape
    {
        public int Width;
        public int Height;
        // Normal method
        public void Print()
        {
            Console.WriteLine("Performing base class printing tasks.");
        }
        // Virtual method: provide a default implementation. Can be overridden if necessary 
        public virtual void Drawing()
        {
            Console.WriteLine("Performing base class drawing tasks.");
        }
        // Abstract method: sub-classes MUST override
        public abstract void Display();
    }

    // Child class
    class Circle : Shape
    {
        public override void Drawing()
        {
            Console.WriteLine("Drawing a circle");
        }
        public override void Display()
        {
            Console.WriteLine("Display circle");
        }
    }

    // Child class
    class Rectangle: Shape
    {
        public override void Drawing()
        {
            Console.WriteLine("Drawing a rectangle");
        }
        public override void Display()
        {
            Console.WriteLine("Display rectangle");
        }
        public new void Print()
        {
            Console.WriteLine("Print rectangle");
        }
    }
    class Program
    {
        static void Main(string[] args)
        {
            Shape p = new Circle();
            p.Drawing();
            p.Display();
            p = new Rectangle();
            p.Drawing();
            p.Display();
            p.Print();
            Console.ReadLine();
        }
    }
}
