using System.Collections;

namespace Evalq7queue
{
     class Person
     {
        static void Main(string[] args)
        {
            Queue queue = new Queue();
            string name;
            int age;
            Console.WriteLine("Enter the name and age : ");
            for (int i = 1; i <= 5; i++)
            {
                name = Console.ReadLine();
                age = int.Parse(Console.ReadLine());
                queue.Enqueue(name);
                queue.Enqueue(age);
            }
            Console.WriteLine("The list of people are : ");
            foreach (var a in queue)
            {
                Console.WriteLine(a);
            }

        }
     }
}