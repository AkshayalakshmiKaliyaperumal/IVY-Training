// See https://aka.ms/new-console-template for more information

using System.Linq;
using System.Security.Cryptography.X509Certificates;

public class Program
{
    class student {
        public string name;
        public int studid, Age;
    }
    public static void Main()
    {

        string[] name = { "Akshaya", "Priya", "Asha", "Vivek" };
        int[] ints = { 1, 2, 3, 4, 5, 6, 7, 8, 9, 10, 11, 12 };
        List<student> studentlist = new List<student>()
        {
            new student()
            {
                studid=1,name="Akshaya",Age=21
            },
            new student()
            {
                studid=2,name="Priya",Age=20
            },
            new student()
            {
                studid=3,name="Akash",Age=22
            },
            new student()
            {
                studid=4,name="Vivek",Age=17
            },
            new student()
            {
                studid=5,name="Asha",Age=19
            }
        };
            //    foreach (string s in name) {

        //        if (name.Contains("a"))
        //        {
        //            Console.WriteLine(s);
        //        }
        //        }

        var linquery = from n in name
                       where n.Contains("a") select n;
        foreach (var n in linquery)
        {
            Console.WriteLine(n);
        }

        var linquery1 = from i in ints
                        where i > 5 && i < 10 select i;
        foreach (var n in linquery1)
        {
            Console.WriteLine(n);
        }
        //var linquery2 = from s in studentlist
        //                where (s.Age > 17 && s.Age < 22 );

        var linquery2 = studentlist.Where(s=>s.Age > 17 && s.Age < 22).ToList<student>();



        foreach  (student n in linquery2)
        {
            Console.WriteLine(n.studid+" "+n.name+" "+n.Age);
        }

        Console.WriteLine();

        var linquery3 = from s in studentlist
                        orderby s.Age ascending select s;

        foreach (student n in linquery3)
        {
            Console.WriteLine(n.studid + " " + n.name + " " + n.Age);
        }
    }

    }

