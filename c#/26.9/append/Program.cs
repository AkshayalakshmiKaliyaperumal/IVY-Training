namespace append
{
    internal class Program
    {
        static void Main(string[] args)
        {
            StreamWriter sw = File.AppendText("C:\\Users\\akaliyaperumal\\OneDrive - Entain Group\\Documents\\FileStream\\test.txt");
            sw.WriteLine("I am writing this to an existing File.");
            sw.WriteLine("Thank you!");
            sw.Close();
        }
    }
}