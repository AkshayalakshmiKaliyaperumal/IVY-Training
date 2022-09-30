namespace Evalq9delegates
{
    internal class Employee
    {
        public delegate void trigger(string name);

        public void promotion(string name)
        {
            Console.WriteLine("Promotion is given to " + name);
        }
        public string[] names = new string[] {"Akshaya","Priya","Lakshmi","Madhu","Sruthi"};

        static void Main(string[] args)
        {
            Employee emp = new Employee();  
            Console.WriteLine("Enter name to give Promotion : ");
            string name = Console.ReadLine();
            trigger t = new trigger(emp.promotion);
            foreach (string s in emp.names) {
                if (s == name)
                {
                    t.Invoke(name);
                }
            }
            
        }
    }
}