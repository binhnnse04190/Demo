using System;

namespace Demo3_Delegate_Event
{
    //bước 1 tạo 1 delegate có tham số là thứ sẽ thay đổi
    public delegate void UpdateNameHandler(string name);
    class Student
    {
        //Bước 2 tạo ra 1 sự kiện hay thông báo (gọi là Event) để lắng nghe khi có 1 sự kiện thay đổi về Name
        public event UpdateNameHandler NameChanged; //tương đương với một delegate
        string name;
        public string Name { get => name; set { name = value; if (NameChanged != null) { NameChanged(name); } } }
    }
    class Program
    {
        static void Main(string[] args)
        {
            //Bước 3 tham chiếu tới Event để thông báo khi có hành động thay đổi s.Name

            Student s = new Student();
            s.NameChanged += S_NameChanged;
            s.Name = "bình";
            Console.WriteLine("Name: "+s.Name);
            s.Name = "Nam";
            Console.WriteLine("Name: " + s.Name);
        }

        private static void S_NameChanged(string name)
        {
            Console.WriteLine("New Student Name: "+name);
        }
    }
}
