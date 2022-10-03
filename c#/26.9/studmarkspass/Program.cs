namespace studmarkspass
{
    internal class Program
    {
        public void genericmethod<T1,T2,T3>(T1 id, T2 name, T3 status)
        {
            Console.WriteLine(id + " , " + name + " , " + status);
        }
        static void Main(string[] args)
        {
            Program p = new Program();
            Console.WriteLine("The List of Students ID, Name along with their status");
            p.genericmethod<int, string, char>(1, "Akshaya", 'Y');
            p.genericmethod<int, string, char>(2, "Lakshmi", 'N');
            p.genericmethod<int, string, char>(3, "Priya", 'Y');
            p.genericmethod<int, string, char>(4, "Gayathri", 'Y');
            p.genericmethod<int, string, char>(5, "Madhu", 'N');

        }
    }
}