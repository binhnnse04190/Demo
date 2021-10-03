using System;

namespace Demo_Create_Delegate
{
    class Program
    {
        //Delegate: Là một kiểu tham chiếu được sử dụng để tham chiếu tới các hàm (method) trong chương trình
        //          Được sử dụng để quản lý các sự kiện
        // Làm việc delegate thông qua 3 bước:
        // - 1 Tạo ra 1 delegate
        // - 2 Thiết lập phương thức (method) mục tiêu cho tham chiếu
        // - 3 Thực thi phương thức mục tiêu thông qua delegate

        //Syntax : [access_modifier] Delegate Data_Type DelegateName([parameters])
        //1 . Tạo 1 delegate: có thể tạo trong hoặc ngoài class

        public delegate int MyDelegate(int oneNumber, int twoNumber);

        //Tạo 1 method mục tiêu để delegate tham chiếu (trỏ) tới

        static int Add(int oneNumber, int twoNumber) => oneNumber + twoNumber;

        static int Sub(int oneNumber, int twoNumber) => oneNumber - twoNumber;

        static void Main(string[] args)
        {
            int n1 = 10, n2 = 20, result;
            //2. Khai báo 1 biến kiểu delegate => thiết lập phương thức mục tiêu (method)
            MyDelegate myDelegate = Add;

            //3. Thực thi phương thức mục tiêu, truyền đối số vào phương thức mà nó tham chiếu tới
            result = myDelegate(n1, n2);
            Console.WriteLine(result);

            MyDelegate myDelegate1 = Sub;
            result = myDelegate1(n1, n2);
            Console.WriteLine(result);
        }
    }
}
