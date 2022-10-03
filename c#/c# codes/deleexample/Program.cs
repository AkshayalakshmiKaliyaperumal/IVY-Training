using System.Threading;

namespace deleexample
{
    internal class Program
    {
        public delegate void calldisplay();
        public delegate void calladd(int a, int b);

         public void display()
        {
            Console.WriteLine("Hello");
        }
    
        public void add(int a,int b)
        {
            Console.WriteLine("Res = " + (a+b));
        }
        static void Main(string[] args)
        {

            Program p = new Program();
            calldisplay disp = new calldisplay(p.display);
            calladd ad = new calladd(p.add);
            disp();
            ad(2, 3);

        }
    }
}