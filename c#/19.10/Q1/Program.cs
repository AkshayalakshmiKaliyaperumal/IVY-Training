namespace Q1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            StreamReader sr = new StreamReader("C:\\Users\\akaliyaperumal\\OneDrive - Entain Group\\Documents\\FileStream\\sample.txt");
            Console.WriteLine(sr.ReadToEnd()); 
        }
    }
}