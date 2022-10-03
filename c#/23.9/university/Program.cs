using System;
using System.ComponentModel.Design;
using System.Xml.Linq;

namespace ConsoleApp4

{
    public class University
    {
        public string university_name = "Abc";
        public int id;
        public string name;
        public string description;
    }
    public class Student : University
    {
        public void Library(int id, string name, string designation)
        {
            Console.WriteLine("Name : " + name);
            Console.WriteLine("ID No. : " + id);
            Console.WriteLine("Students can take a book for a week.");
            Console.WriteLine("You have taken a book today. Your due is in 7 days.");
            Console.WriteLine(name + " gave attendance and attended the class.");
        }
    }
    public class Teacher : Student
    {
        public void Library(string name, int id, string designation)
        {
            Console.WriteLine("Name : " + name);
            Console.WriteLine("ID No. : " + id);
            Console.WriteLine("Teachers can take a book for two weeks.");
            Console.WriteLine("You have taken a book today. Your due is in 14 days.");
            Console.WriteLine(name + " took attendance and a class.");
        }
    }

    public class Librarian : Teacher
    {
        public void Library(string designation, string name, int id)
        {
            Console.WriteLine("Name : " + name);
            Console.WriteLine("ID No. : " + id);
            Console.WriteLine("Librarians can allot books.");
            Console.WriteLine(name + " took attendance.");
        }

    }
    class sample : Librarian
    {
        static void Main(string[] args)
        {
            sample s = new sample();
            s.Library(1, "Akshaya", "Student");
            s.Library("Lakshmi", 2, "Teacher");
            s.Library("Librarian", "Aksh", 3);

        }
    }
}
