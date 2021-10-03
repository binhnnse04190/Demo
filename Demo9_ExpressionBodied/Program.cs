using System;

namespace Demo9_ExpressionBodied
{
    class Student
    {
        public double mark1, mark2;
        string fName, lName;
        // Expression bodies: Properties
        public string FName { get => fName; set => fName = value; }
        public string LName { get => lName; set => lName = value; }

        public Student() { }
        // Expression bodies: Parameterizes Constructor
        public Student(string _fName, string _lName) => (FName, LName) = (_fName, _lName);

        // Expression bodies: Methods
        public double AvgMark() => (mark1 + mark2) / 2;
        public override string ToString() => $"{FName} {LName} - {AvgMark()}";
    }
    class Program
    {
        static void Main(string[] args)
        {
            Student student = new Student("Hung", "Pham Minh");
            student.mark1 = 7;
            student.mark2 = 8;
            Console.WriteLine(student);

            // Object Initialize
            var student1 = new Student { FName = "Chau", LName = "Pham Ngoc", mark1=8.5, mark2=9 };
            Console.WriteLine(student1);
        }
    }
}
