using System;

namespace Demo7_Interface_Inheritance
{
    interface ICar
    {
        void Drive();
    }
    interface IUnderWarterCar
    {
        void Drive();
    }
    interface IJameBondCar:ICar, IUnderWarterCar
    {
        void TurboBoost();
    }

    class MyClass: IJameBondCar
    {
        public void TurboBoost()
        {
            // Do something
        }
        public void Drive()
        {
            // Do something
        }
    }
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");
        }
    }
}
