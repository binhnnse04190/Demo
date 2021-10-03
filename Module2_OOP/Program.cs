using System;

namespace Module2_OOP
{
    class Program
    {
        static void Main(string[] args)
        {
            //Khi đã có cấu trúc của một đối tượng (ở đây là Class Car) thì sẽ đến hàm Main để khởi tạo đối tượng
            Car car = new Car("",""); //sử dụng default constructor
            //Truy xuất các thành phần trong car
            car.inputData("2022"," ");
            car.displayData();
        }
    }
}
