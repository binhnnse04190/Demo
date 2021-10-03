using System;

namespace Demo1_GenericType
{
    //Định nghĩa 1 cái GenericClass để cho phép xử lí các dữ liệu với kiểu <T> trong 1 collection
    //T: Là 1 kí hiệu đại diện cho kiểu dữ liệu mà thực tế cần làm việc
    class MyClass<T>
    {
        //Khai báo 1 property kiểu T
        public T Value { get; set; }
        public override string ToString() => $"Value = {Value}"; //
        
    }
    class GenericClass
    {
        //static void Main(string[] args)
        //{
        //    //khởi tạo 1 đối tượng có kiểu Generic class
        //    MyClass<int> myClass = new MyClass<int>() { Value = 10 }; //object intialize
        //    Console.WriteLine(myClass);
        //    MyClass<string> myClass1 = new MyClass<string> { Value = "Hello" };
        //    Console.WriteLine(myClass1);

        //    dynamic obj = new { ID = 1000, Name = "Binh" };
        //    MyClass<dynamic> myClass2 = new MyClass<dynamic> { Value = obj };
        //    Console.WriteLine(myClass2);
        }
    }
}
