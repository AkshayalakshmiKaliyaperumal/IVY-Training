namespace ConsoleApp1
{
    internal class Program
    {
            static void Main(string[] args)
            {
                char a, b, c;
                Console.WriteLine("Enter first letter: ");
                a = Convert.ToChar(Console.ReadLine());
                Console.WriteLine("Enter second letter: ");
                b = Convert.ToChar(Console.ReadLine());
                Console.WriteLine("Enter third letter: ");
                c = Convert.ToChar(Console.ReadLine());
                Console.WriteLine("Result : " + c + b + a);
            }
    }
}