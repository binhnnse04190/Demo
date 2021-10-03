using System;

namespace Demo1_Classes_Objects
{
    class Program
    {
        static void Main(string[] args)
        {
            Car car = new Car();
            car.Make = "2050";
            car.Model = "BMW sport";
            car.Driving();
            car.Accelerating();
            car.Braking();
        }
    }
}
