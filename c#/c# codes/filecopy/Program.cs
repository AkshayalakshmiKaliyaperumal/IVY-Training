namespace filecopy
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Directory.CreateDirectory("c:\\folder1");
            FileStream fs = new FileStream("c:\\folder1\\file1.txt", FileMode.OpenOrCreate, FileAccess.ReadWrite);
            StreamWriter sw = new StreamWriter(fs);
            sw.Write("Hello Everyone, We will copy these contents to another File in another directory.\n");
            sw.Close();
            FileStream fs1 = new FileStream("c:\\folder1\\file2.txt", FileMode.OpenOrCreate, FileAccess.ReadWrite);
            FileStream fs2 = new FileStream("c:\\folder1\\file1.txt", FileMode.OpenOrCreate, FileAccess.ReadWrite);
            fs2.CopyTo(fs1);
            fs1.Close();
            fs2.Close();
            Directory.Move("c:\\folder1", "C:\\folder2");
        }
    }
}