using System.ComponentModel;

namespace AnonSI
{
    internal class Program
    {
        public delegate int Anon(int a,int b,int c);
        static void Main(string[] args)
        {
            //Anon a = delegate (int p,int n, int r)
            //{
            //    return (p * n * r / 100);
            //};
            //Anon a = (p, n, r) =>
            //{
            //    return (p * n * r / 100);
            //};
            Anon a = (p, n, r) => (p * n * r / 100); //return type
            //Anon a = (p, n, r) => Console.WriteLine((p * n * r / 100)); //void type
           Console.WriteLine("Enter the principle amount : ");
            int p = int.Parse(Console.ReadLine());
            Console.WriteLine("Enter the number of years : ");
            int n = int.Parse(Console.ReadLine());
            Console.WriteLine("Enter the rate of interest : ");
            int r = int.Parse(Console.ReadLine());

            Console.WriteLine("Simple Interest : "+a.Invoke(p, n, r));
          
        }
    }
}