using System.Text.RegularExpressions;

namespace Evalq6encrypt
{
    internal class Program
    {
        static void Main(string[] args)
        {
            FileStream fs = new FileStream("C:\\Users\\akaliyaperumal\\OneDrive - Entain Group\\Desktop\\to_be_encrypt.txt", FileMode.OpenOrCreate, FileAccess.ReadWrite);
            StreamReader sr = new StreamReader(fs);
            string line = sr.ReadLine();
            fs.Close();
            sr.Close();

            FileStream fs1 = new FileStream("C:\\Users\\akaliyaperumal\\OneDrive - Entain Group\\Desktop\\encrypted.txt", FileMode.OpenOrCreate, FileAccess.ReadWrite);
            StreamWriter sw = new StreamWriter(fs1);
            foreach (char c in line)
            {
                sw.Write(c - 2);
            }
            sw.Close();
            fs.Close();
            fs1.Close();
        }
    }
}