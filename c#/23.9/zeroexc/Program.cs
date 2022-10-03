using System.Linq.Expressions;

namespace zeroexc
{
    internal class Program
    {
        static void Main(string[] args)
        {
            try
            {
                Console.WriteLine("Enter a number : ");
                int a = Convert.ToInt32(Console.ReadLine());
                Console.WriteLine("Square root of number is : " + Math.Sqrt(a));
                Console.WriteLine("Power of number by 2 is : " + Math.Pow(a, 2));
                Console.WriteLine("Multiplied by 2 : " + a * 2);
                Console.WriteLine("Divided by Zero is : " + a / 0);
            }
            catch (DivideByZeroException e) { Console.WriteLine(e); }
        }
    }
}