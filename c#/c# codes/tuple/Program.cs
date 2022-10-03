namespace tuple
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Tuple<string> t = new Tuple<string>( "Akshaya");
           // Tuple<string> tt = new Tuple<string>
            var t1 = Tuple.Create(1, "Akshaya", 'a',2,"AK" , "hello",25,Tuple.Create(1,2,3,4,5,6,7,Tuple.Create(1,2,3,4)));

            //Console.WriteLine($"{ t1.Item1} , { t1.Item2} , { t1.Item3}");
            //Console.WriteLine(t1);
            //Console.WriteLine(t1.Rest.Item1);
            Console.WriteLine(t1.Rest.Item1.Rest.Item1.Item2);
        }
    }
}