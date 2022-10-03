namespace Evalq5
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter the number for factorial: ");
            int n = int.Parse(Console.ReadLine());
            int i = 1;
            int fact = 1;
            for (i = 1; i <= n; i++)
            {
                fact = fact * i;
            }
            Console.WriteLine("Factorial of the number is : " +  fact);
            Console.WriteLine();
            Console.WriteLine("Enter the number for multiplication table: ");
            int num = int.Parse(Console.ReadLine());
            int j = 1;
            while (j <= 10)
            {
                Console.WriteLine(num + " * " + j + " = " +  (num * j) + " ");
                j++;
            }
        }
    }
}