using System;

namespace Exercises_1
{
    public class Student
    {
        //Creat data field
        public int Id;
        public string Name;
        public DateTime DOB;

        //Creat constructor
        public Student(int id, string name, DateTime DOB)
        {
            this.Id = id;
            this.Name = name;
            this.DOB = DOB;
        }
        ////int GetAge() return the age of the Student 
        public int getAge() => (DateTime.Today.Year - DOB.Year);

        //-	string ToString() return the string contains student’s information by the format 
        public string ToString() => ($"Student’s Information: ID: {Id} – Name: {Name} – Age: {getAge()}");
    }
    class Program
    {
        static void Main(string[] args)
        {
            Student st = new Student(1, "Trung", new DateTime(1990, 11, 10));
            Console.WriteLine("Age of student: " + st.getAge().ToString());
            Console.WriteLine(st.ToString());
            Console.ReadLine();

        }
    }
}
