namespace Q2
{
    internal class Program
    {
        static async void firstfile()
        {
            StreamReader sr = new StreamReader("C:\\Users\\akaliyaperumal\\OneDrive - Entain Group\\Documents\\FileStream\\sample.txt");
            Console.WriteLine(sr.ReadToEnd());
            Console.WriteLine("First task over");
        }

        static async void secondfile()
        {
            Thread.Sleep(3000);
            //await Task.Delay(3000);
            StreamReader sr1 = new StreamReader("C:\\Users\\akaliyaperumal\\OneDrive - Entain Group\\Documents\\FileStream\\sample1.txt");
            Console.WriteLine(sr1.ReadToEnd());
            Console.WriteLine("Second task over");
        }
        static async Task Main(string[] args)
        {
            firstfile();
            Console.WriteLine();
            secondfile();
            Console.ReadKey();
        }
    }
}