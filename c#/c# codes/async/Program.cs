/*namespace async
{
    class juice
    {
        public void pour()
        {
            Console.WriteLine("Juice is poured");
        }
    }
    class eggs
    {
        public async Task<eggs> boil(eggs eggs)
        {
            Console.WriteLine("Eggs are boiled");
            //await Task.Delay(4000);
            return eggs;
        }

    }

    class bread
    {
        public void toast()
        {
            Console.WriteLine("Bread is toasted");

        }
        public void spreadcheese()
        {
            Console.WriteLine("Cheese is spread");
        }
    }

    class fruits 
    {
        public void cut()
        {
            Console.WriteLine("Fruits are cut");
        }
    }

    internal class Program
    {
        static async void Main(string[] args)
        {
            juice myjuice = new juice();
            myjuice.pour();
            eggs myeggs = new eggs();
            await myeggs.boil(myeggs);
            //Task<eggs> myeggs = boil("boil");
            //var v = await myeggs;
            bread mybread = new bread();
            mybread.toast();
            mybread.spreadcheese();
            fruits myfruits = new fruits();
            myfruits.cut();
            Console.WriteLine("Lunch is ready!");

        }
    }
}*/
namespace _2.AsynchronousProgramming
{
    internal class Program
    {
        static Dictionary<int,string> d = new Dictionary<int,string>();  
        static async Task<Dictionary<int,string>> FirstMethod()
        {
            int a = 12;
            string b = "hello ";
            d.Add(a, b);
            Console.WriteLine("1st method execution started");
            /*Thread.Sleep(5000);*/
            await Task.Delay(3000);
            Console.WriteLine("1st Method Execiton Completed");
            return d;

        }
        static void SecondMethod()
        {

            Console.WriteLine("2nd method execution started");
            Thread.Sleep(1000);
            Console.WriteLine("2nd Method Execiton Completed");
        }
        static async Task Main(string[] args)
        {
            try
            {
                //Task<string> b = FirstMethod();
                Task<Dictionary<int , string>> b = FirstMethod();
                SecondMethod();
                //var c = b.Result;
                var c = await b;
                //Console.WriteLine(b.Result);
                foreach (var x in c)
                {
                    Console.WriteLine(x);
                    Console.WriteLine();
                }
                //    foreach (KeyValuePair<int,string> g in c)
                //    {
                //        Console.WriteLine(g.Key + g.Value);
                //    }
            }
            catch (Exception e) { Console.WriteLine(e.Message); }
            Console.ReadKey();
        }
    }
}
