using System;

namespace Demo2_MultiCast_Delegate
{
    //MultiCast(tính đa hướng) trong delegate : Là 1 delegate cho phép tham chiếu tới nhiều phương thức (method, hàm) trong chương trình
    delegate void Mydelegate(string s);
    class Program
    {
        //Các phương thức mục tiêu
        static void ConvertToUpper(string name) => Console.WriteLine(name.ToUpper());

        static void ConvertToLower(string name) => Console.WriteLine(name.ToLower());

        static void Display(string name) => Console.WriteLine(name);
        static void Main(string[] args)
        {
            string name = " Nguyen Ngoc Binh";
            Mydelegate mydelegate = ConvertToUpper;
            Mydelegate mydelegate1 = ConvertToLower;
            Mydelegate multicast = mydelegate + mydelegate1;
            Console.WriteLine("---delegate + delegate1");
            multicast(name);

            //thêm một phương thức delegate bằng toán tử +=
            Mydelegate mydelegate2 = Display;
            multicast += mydelegate2;
            Console.WriteLine("---delegate + delegate1 + delegate2");
            multicast(name);

            //xóa 1 phương thức delegate bằng toán tử -=
            multicast -= mydelegate1;
            Console.WriteLine("Sau khi xóa: ");
            multicast(name);
        }
    }
}
