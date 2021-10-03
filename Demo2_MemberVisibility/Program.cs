using System;

namespace Demo2_MemberVisibility
{
    abstract class Car
    {
        public Car(string make, string model)
        {
            Make = make;
            Model = model;
        }

        public string Make { get; set; }
        public string Model { get; set; }


        public void sumCar()
        {
            Console.WriteLine(Model);
        }
        public virtual void inputData(string make, string model)
        {
            Console.WriteLine("{0},{1}", make, model);
        }

        public abstract void disPlay();

    }

    class Car2 : Car
    {
        public void inputData2(string make, string model)
        {
            Console.WriteLine($"Make {make} Model {model}");
        }

        public override void disPlay()
        {
            Console.WriteLine($"Make {Make}, Model {Model}");
        }

        public Car2(string make, string model) : base(make, model)
        {

        }
    }
    class Program
    {
        static void Main(string[] args)
        {
            Car car = new Car2("20", "20");
            car.inputData("100", "100");
            Console.WriteLine($"Model: {car.Model}");
            car.disPlay();
            


        }
    }
}
