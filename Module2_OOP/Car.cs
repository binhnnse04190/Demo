using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Module2_OOP
{
    //Định nghĩa một nguyên mẫu cho các đối tượng có kiểu Car (class)
    class Car
    {
        //Thành phần trong class gồm 2 thành phần:
        //Data fields: Mô tả đặc tính hay đặc điểm của đối tượng
        string make;
        string model;

        //Methods: Là những hành vi hay hành động để tác động lên data fields

        public void inputData(string make, string model)
        {
            this.make = make;
            this.model = model;
        }
        public void displayData()
        {
            Console.WriteLine($"Make {make}, Model {model}");
        }
    }
}
