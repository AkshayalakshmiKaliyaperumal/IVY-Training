namespace studentmarks
{
    internal class Program
    {
        static void Main(string[] args)
        {
            SortedList<int,int> list = new SortedList<int,int>();
            list.Add(1, 80);
            list.Add(2, 90);
            list.Add(3, 85);
            list.Add(5, 65);
            list.Add(4, 70);
            Console.WriteLine("Student IDs and their Mark : ");
            foreach (KeyValuePair<int, int> l in list)
            {
                Console.WriteLine(l.Key + " " + l.Value);
            }
            Console.WriteLine("Highest Mark : " + list.Values.Max());
            Console.WriteLine("Lowest Mark : " + list.Values.Min());
        }
    }
}