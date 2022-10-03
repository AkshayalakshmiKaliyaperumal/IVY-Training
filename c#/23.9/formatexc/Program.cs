using System.Linq.Expressions;


namespace formatexc
{
    public class Program
    {
        static void Main(string[] args)
        { 
            try
            {
                string str;
                Console.WriteLine("Enter a word: ");
                str = Console.ReadLine();
                int s = Convert.ToInt32(str);
            }
            catch(FormatException e){ Console.WriteLine(e);}
            finally { Console.WriteLine("End of the Code"); }
        }
    }
}
