using System;

namespace Demo11_ReadOnly_Const
{
    class SamplePoint
    {
        public int x;
        // Khởi tạo readonly field
        public readonly int y = 25;
        public readonly int z;
        // Khởi tạo 1 const field
        public const int t = 100;
        public SamplePoint()
        {
            // Gán giá trị cho readonly
            z = 24;
        }
        public SamplePoint(int p1, int p2, int p3, int p4 = 50)
        {
            x = p1;
            y = p2;
            z = p3;
            // t = p4; // Lỗi: vì t là 1 constant -> Không được thay đổi giá trị
        }
    }
    class Program
    {
        static void Main(string[] args)
        {
            SamplePoint point = new SamplePoint(11, 21, 32);
            Console.WriteLine($"t = {SamplePoint.t}");
            Console.WriteLine($"x = {point.x}, y = {point.y}, z = {point.z}");

            SamplePoint point1 = new SamplePoint();
            Console.WriteLine($"x = {point1.x}, y = {point1.y}, z = {point1.z}");

            Console.ReadLine();
        }
    }
}
