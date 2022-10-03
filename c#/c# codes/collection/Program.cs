namespace collection
{
    internal class Program
    {
        static void Main(string[] args)
        {
            /*var ll = new LinkedList<int>();
            ll.AddLast(1);
            ll.AddLast(2);
            ll.AddLast(3);
            ll.AddLast(4);
            ll.AddLast(5);
            ll.AddLast(6);
            ll.AddFirst(7);
            ll.AddFirst(8);
            foreach(int i in ll)
            {
                Console.WriteLine(i);
            }
            Console.WriteLine();
            LinkedListNode<int> l = ll.Find(5);
            Console.WriteLine(l.Value);
            ll.AddAfter(l, 11);
            Console.WriteLine();
            foreach (int i in ll)
            {
                Console.WriteLine(i);
            }
            Console.WriteLine();
            Console.WriteLine(l.Next.Value);*/

            /*Dictionary<string, string> d = new Dictionary<string, string>();
            d.Add("1", "Akshaya");
            d.Add("2", "Lakshmi");
            d.Add("3", "jungkook");
            foreach(KeyValuePair<string,string>k in d)
            {
                Console.WriteLine(k.Key + " "+ k.Value);            
            }
            Console.WriteLine();

            d.Remove("1");
            foreach (KeyValuePair<string, string> k in d)
            {
                Console.WriteLine(k.Key + " " + k.Value);
            }

            Console.WriteLine();
            string m1 = d.Keys.Min();
            Console.WriteLine(m1);

            Console.WriteLine();
            string m = d.Values.Min();
            Console.WriteLine(m);*/

           /* SortedList<string,string> list = new SortedList<string,string>();
            list.Add("Jeon", "Jungkook");
            list.Add("Kim", "Taehyung");
            //list.Add("Kim", "jin");
            list.Add("Park", "Jimin");
            list.Add("Min", "Jimin");
            foreach(KeyValuePair<string,string> pair in list)
            {
                Console.WriteLine(pair.Key + " " + pair.Value);
            }*/

            SortedDictionary<string, string> list = new SortedDictionary<string, string>();
            list.Add("Jeon", "Jungkook");
            list.Add("Kim", "Taehyung");
            //list.Add("Kim", "jin");
            list.Add("Park", "Jimin");
            list.Add("Min", "Jimin");
            foreach (KeyValuePair<string, string> pair in list)
            {
                Console.WriteLine(pair.Key + " " + pair.Value);
            }

            Console.WriteLine();
            list.Remove("Kim");
            foreach (KeyValuePair<string, string> pair in list)
            {
                Console.WriteLine(pair.Key + " " + pair.Value);
            }



        }

    }
} 