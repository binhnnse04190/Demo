using System;
using System.Collections.Generic;

namespace Exercises_2
{
    public class MyCollection<T>
    {
        //One ArrayList or List or array to store list of object of type T. T can be any built-in data type or any class.

        List<T> list = new List<T>();
        public T obj;

        //void Add(T obj) to add the object obj into the above list at last position.
        public void Add(T obj) => list.Add(obj);

        //void Add(T obj, int k) to add the object obj into the position indexed k in the above list
        public void Add(T obj, int k) => list.Insert(k, obj);

        //void DisplayItems() to write to the screen the information of items in the list. 
        
        public void DisplayItems()
        {
            foreach (T item in list)
            {
                Console.WriteLine(item);
            }
        }

    }
    class Program
    {
        static void Main(string[] args)
        {
            MyCollection<int> myCollection = new MyCollection<int>();
            myCollection.Add(1);
            myCollection.Add(2);
            myCollection.Add(3);
            myCollection.Add(4, 1);
            
            myCollection.DisplayItems();

            MyCollection<string> StringCollection = new MyCollection<string>();
            StringCollection.Add("aa");
            StringCollection.Add("bb");
            StringCollection.Add("cc");
            StringCollection.Add("dd", 1);
            Console.WriteLine("Display string list:");
            StringCollection.DisplayItems();

            Console.ReadLine();

        }
    }
}
