using System;

namespace Evalq1array
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int[] arr = new int[10];
            Console.WriteLine("Enter the values for Array : ");
            for(int i = 0; i < arr.Length; i++)
            {
                arr[i] = int.Parse(Console.ReadLine());
            }
            int max = arr.Max();
            Console.WriteLine("Maximum value of array is " + max);
            int min = arr.Min();
            Console.WriteLine("Minimum value of array is " + min);
            Console.ReadKey();
        }
    }
}