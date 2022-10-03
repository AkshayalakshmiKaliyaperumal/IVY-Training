using System.ComponentModel;
using System.Transactions;

namespace delegates
{
    internal class Program
    {
        public delegate int num(int n);

        public static int factorial(int n)
        {
            int i = 1;
            int fact = 1;
            for(i = 1; i <= n; i++)
            {
                fact = fact * i;
            }
            return fact;
        }
        public static int fibonacci(int n)
        {
            int a = 0;
            int b = 1;
            int c = 0;
            Console.Write(a + " , " + b);
            for(int i = 1; i <= n; i++)
            {
                c = a + b;
                a = b;
                b = c;
                Console.Write(" , " + c);
                i++;
            }
            return c;
        }
        public static int factorsnumbers(int n)
        {
            for (int i = 1; i <= n; i++)
            {
                if (n % i == 0)
                {
                    Console.Write(i + " ");
                }
            }
            return n;
   
        }
        public static int tablenumbers(int n)
        {
            int i = 1;
            while (i <= 10)
            {
                Console.Write(n * i + " ");
                i++;
            }
            return i;
        }

        static void Main(string[] args)
        {
            num num = new num(Program.factorial);
            Console.WriteLine("Enter a number for factorial : ");
            int n1 = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine(num.Invoke(n1));

            Console.WriteLine("Enter a number for Fibonacci: ");
            int n2 = Convert.ToInt32(Console.ReadLine());
            num = fibonacci;
            //Console.WriteLine(num.Invoke(n2));
            num.Invoke(n2);

            Console.WriteLine();
            Console.WriteLine("Enter a number for Table: ");
            int n3 = Convert.ToInt32(Console.ReadLine());
            num = tablenumbers;
            num.Invoke(n3);

            Console.WriteLine();
            Console.WriteLine("Enter a number for Factors: ");
            int n4 = Convert.ToInt32(Console.ReadLine());
            num = factorsnumbers;
            num.Invoke(n4);

        }
    }
}