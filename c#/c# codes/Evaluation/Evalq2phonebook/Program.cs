using System.Collections;
using System.ComponentModel;
using System.Runtime.CompilerServices;
using static System.Formats.Asn1.AsnWriter;

namespace Evalq2phonebook
{
    public class PhoneBook
    {
        public string name, profession;
        public int age;
        public double phnnum;

        public Dictionary<String,String> professional= new Dictionary<String,String>();
        public Hashtable student = new Hashtable();
        public Hashtable service = new Hashtable();
    }
    class Student : PhoneBook
    {
        public void Stud(string name, string age, string phnnum)
        {
            student.Add(name , age + " " + phnnum + " " );
        }
        public void display()
        {
            Console.WriteLine("Students : ");
            foreach(DictionaryEntry n in student)
            {
                Console.WriteLine(n.Key + " " + n.Value);
            }
        }
    }
    class Service : PhoneBook
    {
        public void Serv(string name, string age, string phnnum)
        {
            service.Add(name , age + " " + phnnum + " ");
        }
        public void display()
        {

            Console.WriteLine("Service : ");
            foreach (DictionaryEntry n in service)
            {
                Console.WriteLine(n.Key + " " + n.Value);
            }
        }
    }

    class Professional : PhoneBook
    {
        public void Prof(string name, string age, string phnnum,string profession)
        {
         professional.Add(name,age + " " + phnnum + " " + profession + " ");
        }
        public void display()
        {
            Console.WriteLine("Professionals : ");
            foreach(KeyValuePair<string,string> kvp in professional)
            {
                Console.Write(kvp.Key + " " + kvp.Value);
            }
        }
    }

    class main
    {
        static void Main(string[] args)
        {
            Student s = new Student();
            Service s1 = new Service();
            Professional p = new Professional();
            int i = 1;
            while (i <= 5)
            {
                Console.WriteLine("Enter the Name : ");
                string name = Console.ReadLine();
                Console.WriteLine("Enter the Age : ");
                string age = Console.ReadLine();
                Console.WriteLine("Enter the Phone Number  : ");
                string phnnum = Console.ReadLine();
                Console.WriteLine("Enter the Profession : ");
                string profession = Console.ReadLine();
               
                if ((int.Parse(age) <= 18) && profession == "")
                {
                    s.Stud(name, age, phnnum);
                }
                else if ((int.Parse(age) > 18) && profession == "")
                {
                    s1.Serv(name, age, phnnum);
                }
                else
                {
                    p.Prof(name,age,phnnum,profession);
                }
                i++;
                
            }
            s.display();
            s1.display();
            p.display();

        }
    }
}
