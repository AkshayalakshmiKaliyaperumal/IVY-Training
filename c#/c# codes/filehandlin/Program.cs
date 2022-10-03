using System.Text;

namespace filehandlin
{
    internal class Program
    {
        static void Main(string[] args)
        {
            /*using (TextWriter t = File.CreateText("C:\\Users\\akaliyaperumal\\OneDrive - Entain Group\\Documents\\FileStream\\testing.txt"))
            {
                t.WriteLine("Hello!");
                t.WriteLine("Good Morning");
            }
            using (TextReader r = File.OpenText("C:\\Users\\akaliyaperumal\\OneDrive - Entain Group\\Documents\\FileStream\\testing.txt"))
            {
                Console.WriteLine(r.ReadToEnd());
            }
            StreamReader sr = new StreamReader("C:\\Users\\akaliyaperumal\\OneDrive - Entain Group\\Documents\\FileStream\\test.txt");
            Console.WriteLine(sr.ReadToEnd());*/

            /*string filename = ("C:\\Users\\akaliyaperumal\\OneDrive - Entain Group\\Documents\\FileStream\\Bin.dat");
            BinaryWriter b = new BinaryWriter(File.Open(filename, FileMode.Create));
            b.Write("Akshaya");
            b.Close();
            BinaryReader r = new BinaryReader(File.Open(filename, FileMode.Open));
            Console.WriteLine(r.ReadString());*/

            string s = "Hello Everyone,\nHave a nice day.\nSee you later";
            //sringBuilder sb = new StringBuilder();
            StringWriter sw = new StringWriter();
            sw.WriteLine(s);
            sw.Close();
            StringReader sr = new StringReader(sw.ToString());
            Console.WriteLine(sr.ReadToEnd());




        }
    }
}