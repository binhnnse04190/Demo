using System;
using System.Collections.Generic;

namespace ExercisesDictionaryGeneric
{
    
    public class Student
    {
        int studentID;
        string studentName;

        //public property
        public int StudentID { get; set; }
        public string StudentName { get; set; }

        //Call constructor
        public Student(int studentID, string studentName) => (StudentID, StudentName) = (studentID, studentName);
        public Student() { }


        public override string ToString()
        {
            return $"{StudentID} - {StudentName}";
        }


    }
    public delegate void OnNumberOfStudentChange(int oldNumber, int newNumber);
    public class Course
    {
        
        int courseID;
        string courseTitle;
        public event OnNumberOfStudentChange Notify;

        Dictionary<Student, double> list = new Dictionary<Student, double>();

        public int CourseID { get; set; }
        public string CousreTitle { get; set; }

        public Course(int courseID, string courseTitle) => (CourseID, CousreTitle) = (courseID, courseTitle);

        public void Add(Student p, double g)
        {
            list.Add(p, g);
            //gọi event Notify by delegate OnNumberOfStudentChange
            //vì sao lại là list.count - 1 ? Vì khi add thì số lượng phần tử của array đã tăng lên 1
            //mà tham số ở đây là "oldNumber" vậy nên số phần tử cũ sẽ là số phần tử mới trừ đi 1 và tham số 2 là "newNumber" sẽ là số lượng phần tử mới sau khi add
            if (Notify != null) { Notify(list.Count - 1, list.Count); }
        }

        public void Remove(int studentID)
        {
            foreach (var item in list)
            {
                if (item.Key.StudentID == studentID)
                {
                    list.Remove(item.Key);
                }

            }
            //gọi event Notify by delegate OnNumberOfStudentChange
            //vì sao lại là list.count - 1 ? Vì khi Xóa thì số lượng phần tử của array đã cộng thêm 1 và tham số 2 là "newNumber" sẽ là số lượng phần tử mới sau khi xóa
            if (Notify != null) { Notify(list.Count + 1, list.Count); }
        }

        public override string ToString()
        {
            string result = "";

            foreach (var item in list)
            {
                result += $"Student: {item.Key} - Mark: {item.Value}\n";
            }


            return $"Course: {CourseID} - {CousreTitle}\n{result}";

        }



    }
    class Program
    {
        static void Main(string[] args)
        {
            Student s = new Student(1, "Trung");
            Course c = new Course(1, "PRN211_Sum21");
            c.Add(s, 7.5);
            c.Add(new Student(2, "Hoa"), 7.8);
            c.Add(new Student(3, "Vinh"), 7.4);
            Console.WriteLine(c);
            Console.WriteLine("----------After Remove:");
            c.Remove(2);
            Console.WriteLine(c);
            c.Notify += C_Notify;
            c.Add(new Student(4, "Binh"), 7.8);
            c.Remove(1);
            Console.WriteLine(c);
            Console.ReadLine();
        }

        private static void C_Notify(int oldNumber, int newNumber)
        {
            Console.WriteLine($"Number of student has change from {oldNumber} to {newNumber}");
        }
    }
}
