using static sumofnumbers.Program;

namespace sumofnumbers
{
    internal class Program
    {
        public delegate void sum(int n);
        public delegate void greater(int a, int b);
        public delegate bool prime(int p);
        public delegate void prime_n(int x);
        public delegate void array(int[] x);

        static void Main(string[] args)
        {
            Console.WriteLine("Enter the number to calculate sum of n numbers : ");
            int n = int.Parse(Console.ReadLine());
            sum s = (n) =>
            {
                int result = 0;
                for (int i = 1; i <= n; i++)
                {
                    result += i;
                }
                Console.WriteLine("Sum of n numbers = " + result);
            };
            s.Invoke(n);


            Console.WriteLine("Enter the number two numbers to find greater number : ");
            int a = int.Parse(Console.ReadLine());
            int b = int.Parse(Console.ReadLine());
            greater g = (a, b) => Console.WriteLine("Greater number = " + (a > b ? a : b));
            g.Invoke(a, b);


            Console.WriteLine("Enter two numbers to swap");
            int c = int.Parse(Console.ReadLine());
            int d = int.Parse(Console.ReadLine());
            greater sw = (c, d) => Console.WriteLine("After swapping = " + (c = c ^ d ^ (d = c)) + " and " + d);
            sw.Invoke(c, d);


            Console.WriteLine("Enter the num to check prime or not: ");
            int num = int.Parse(Console.ReadLine());
            prime prime = delegate (int num)
            {
                int c = 0;
                for (int i = 1; i < num; i++)
                    if (num % i == 0)
                        c++;
                if (c == 1) return true;
                else return false;
            };
            Console.WriteLine("Ans: " + prime.Invoke(num));


            Console.WriteLine("Enter a number to find Prime numbers : ");
            int num1 = int.Parse(Console.ReadLine());
            prime_n prime1 = (n) => { if (prime.Invoke(n)) Console.Write(n + " "); };
            Console.WriteLine("Prime numbers till {0}: ", num1);
            for (int i = 1; i < num1; i++)
                prime1.Invoke(i);


            Console.Write("\nEnter the array size: ");
            int size = int.Parse(Console.ReadLine());
            Console.WriteLine("Enter the Values now: ");
            int[] arr = new int[size];
            for (int i = 0; i < size; i++)
                arr[i] = int.Parse(Console.ReadLine());
            array ar = (x) => Array.Sort(x);
            ar.Invoke(arr);
            Console.WriteLine("\nAfter sorting: ");
            foreach (int i in arr) 
                Console.Write(i + " ");
        }
    }
}