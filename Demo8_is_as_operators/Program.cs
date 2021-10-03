using System;

namespace Demo8_is_as_operators
{
    interface ICalculate
    {
        double Area();
        double Perimeter();
    }
    class Rectangle : ICalculate
    {
        float length, width;
        public Rectangle(float l, float w)
        {
            length = l;
            width = w;
        }

        public double Area()
        {
            return width * length;
        }

        public double Perimeter()
        {
            return 2 * (width + length);
        }
    }
    class Square : ICalculate
    {
        float side;
        public Square(float s)
        {
            side = s;
        }

        public double Area()
        {
            return side * side;
        }

        public double Perimeter()
        {
            return 4 * side;
        }
    }
    class Program
    {
        static void Main(string[] args)
        {
            Rectangle rectangle = new Rectangle(10.5F, 8.5F);
            Square square = new Square(6.5F);
            ICalculate calculate;
            if(rectangle is ICalculate)
            {
                calculate = rectangle as ICalculate;
                Console.WriteLine($"Rectangle - Area: {calculate.Area():F2}, Perimeter: {calculate.Perimeter()}");
            }
            if(square is ICalculate)
            {
                calculate = square as ICalculate;
                Console.WriteLine($"Square - Area: {calculate.Area()}, Perimeter: {calculate.Perimeter()}");
            }
        }
    }
}
