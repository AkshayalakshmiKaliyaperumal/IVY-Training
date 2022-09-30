namespace Evalq8replace
{
    internal class Program
    {
        static void Main(string[] args)
        {
            FileStream fs = new FileStream("C:\\Users\\akaliyaperumal\\OneDrive - Entain Group\\Desktop\\sample.txt", FileMode.OpenOrCreate,FileAccess.ReadWrite);
            StreamWriter sw = new StreamWriter(fs);
            sw.WriteLine("I have a best friend XYZ.He is my classmate.We play together.We also do our homework together.We share our lunches.He is good in studies.He helps me solve math sums.My parents like him too.His parents treat me like a son.I love my best friend.");
            sw.Close();
            fs.Close();

            Console.WriteLine("Hint = Best Friend.");
            Console.WriteLine("Enter the File name : ");
            string filename = " ";
            filename = Console.ReadLine();
            string path = "C:\\Users\\akaliyaperumal\\OneDrive - Entain Group\\Desktop\\" + filename + ".txt";
            


            Console.WriteLine("Enter the old word : ");
            string oldword = Console.ReadLine();
            Console.WriteLine("Enter the new word : ");
            string newword = Console.ReadLine();


            string line = " ";
            FileStream fs1 = new FileStream("C:\\Users\\akaliyaperumal\\OneDrive - Entain Group\\Desktop\\sample.txt", FileMode.OpenOrCreate,FileAccess.ReadWrite);
            FileStream fs2 = new FileStream(path, FileMode.OpenOrCreate, FileAccess.ReadWrite);
            StreamWriter sw1 = new StreamWriter(fs2);
            StreamReader sr = new StreamReader(fs1);
            while((line = sr.ReadLine()) != null)
            {
                if (line.Contains(oldword))
                {
                    string newline = line.Replace(oldword, newword);
                    sw1.WriteLine(newline);
                }
                else
                {
                    sw1.WriteLine(line);
                }
            }
            
            sw1.Close();
            sr.Close();
            fs1.Close();
            fs2.Close();
        }
    }
}