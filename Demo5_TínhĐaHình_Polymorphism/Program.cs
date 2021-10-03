using System;

namespace Demo5_TínhĐaHình_Polymorphism
{
    //Nếu mà abtract class không 
    abstract class Shape
    {//1 lớp abstract có thể chứa
        //Property
        public int Height { get; set; }
        public int Weight { get; set; }

        //public Shape (int Height, int Weight)
        //{
        //    Height = Height;
        //    Weight = Weight;
        //}
                
        //Non-Abstrace method
             public void Print()
        {
            Console.WriteLine($"Height: {Height}, Weight: {Weight}");
        }
        //Virtual methods: Cho phép các class con có thể (hoặc không) ghi đè lại nó
        public virtual void Draw()
        {
            Console.WriteLine("Drawing");
        }

        //Abstract method: là các phương thức bắt buộc phải được override tại các class con
        //Phương thức kiểu này không có nội dung
        public abstract void Display();
        

        //Constructor có tham số (parameter)
    }

    class Circle : Shape
    {
        //không cần phải class cha phải có constructor, vì class con đã kế thừa property của class Cha
        public Circle(int Height, int Weight)
        {
            this.Height = Height;
            this.Weight = Weight;
        }
    //Override method(phương thức) lớp cha
        public override void Draw()
        {
            Console.WriteLine("Drawing circle");
        }
        
        public override void Display()
        {
            Console.WriteLine("Drawing circle");
        }
        //
        public new void Print()
        {
            Console.WriteLine("Drawing circle");
        }
        public override string ToString()
        {
            return ($"Height {Height}, Weight {Weight}");
        }
    }

    class Rectangle : Shape
    {
        public Rectangle (int Height, int Weight)
        {

        }
        public override void Display()
        {
            throw new NotImplementedException();
        }
    }


    class Program
    {
        static void Main(string[] args)
        {
            Shape shape = new Circle(200, 200);
            Console.WriteLine(shape);
        }
    }
}
