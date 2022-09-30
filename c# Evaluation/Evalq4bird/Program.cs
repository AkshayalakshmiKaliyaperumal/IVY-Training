using System.Xml.Linq;

namespace Evalq4bird
{
    abstract class bird
    {
        public string name;
        public void SetName(string name)
        {
            this.name = name;
        }
        public string GetName()
        {
            return name;
        }
        public abstract void fly();
        
    }
    class parrot : bird
    {
        public override void fly()
        {
            Console.Write(GetName() + " is Flying.");
        }
    }
    class program
    {
        static void Main(string[] args)
        { 
            parrot p = new parrot();
            Console.WriteLine("Enter the bird name : ");
            string s = Console.ReadLine();
            p.SetName(s);
            p.GetName();
            p.fly();
        }
    }
}