using System;

namespace Demo3_TínhĐóngGói
{
    //Encapulation
    class Program
    {
      public class Car
        {
            //Khai báo các data field tường minh
            //protected string make;
            //protected string model;

            //Đón gói dữ liệu của đối tượng : properties
            //public string Make { get; }//thuộc tính chỉ đọc, không được gán giá trị, chỉ được gán giá trị thông qua method trong class
            //public string Model { get => model; set => model = value; }

            ////Automatic properties
            public string Make { get; set; }
            public string Model { get; set; }

            //Read-Only auto properties
            public string Description { get; }

            public Car(string model, string make, string desc)
            {
                Make = make;
                Model = model;
                Description = desc;
            }
            //public virtual void inputData(string make, string model, string desc)
            //{
            //    this.make = make;
            //    this.model = model;
               
            //}
            public virtual void inputMake()
            {
                Console.WriteLine("Binhnnse04190");
            }
            public virtual void Display()
            {
                Console.WriteLine($"Make: {make}, Model: {model}");
            }

        }
        public class Circle:Car
        {
            public override void inputData(string make, string model, string desc)
            {
                base.inputData(make, model, desc);
            }
            public override void inputMake()
            {
                Console.WriteLine("Hello");
            }
            public override void Display()
            {
                Console.WriteLine($"Make: {make}, Model: {model}");
            }
        }
       
        static void Main(string[] args)
        {
            Car car = new Car();
            Circle circle = new Circle();
            car.Model = "2000";
            car.inputData("ádasd", "đâsda");
            car.Display();
            car.inputMake();
            circle.inputMake();
            circle.inputData("binh", "binh");
            circle.Display();
       
        }
    }
}
