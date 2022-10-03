using System.Text.RegularExpressions;

namespace filestream
{
    internal class Program
    {
        static void Main(string[] args)
        {
            FileStream s = new FileStream("C:\\Users\\akaliyaperumal\\OneDrive - Entain Group\\Documents\\FileStream\\test.txt", FileMode.OpenOrCreate);
            s.WriteByte(65);
            StreamWriter w = new StreamWriter(s);
            StreamWriter w = new StreamWriter("C:\\Users\\akaliyaperumal\\OneDrive - Entain Group\\Documents\\FileStream\\test1.txt");
            w.WriteLine("I  am writing into the file");
            w.WriteLine("One more line added");
            w.Close();
            StreamReader sr = new StreamReader("C:\\Users\\akaliyaperumal\\OneDrive - Entain Group\\Documents\\FileStream\\test1.txt");
            string content = " ";
            sr.ReadLine();
            int i = 3;
            while (i >= 3)
            {
                sr.ReadLine();
                i++;
            }
            content = sr.ReadLine();
            Console.WriteLine(content);
            while ((content = sr.ReadLine()) != null)
            {
                content = sr.ReadLine();
                Console.WriteLine(content);
            }
            s.Close();
            Console.WriteLine(content);
            Console.ReadKey();

            StreamReader sr = new StreamReader("C:\\Users\\akaliyaperumal\\OneDrive - Entain Group\\Documents\\FileStream\\test1.txt");
            string content = " ";
            while ((content = sr.ReadLine()) != null)
            {
                Console.WriteLine(content);
            }
            Console.ReadKey();
        }
}
}