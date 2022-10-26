namespace q3
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string path = "c:\\sample";
            Directory.CreateDirectory(path);
            FileStream fs = new FileStream(path + "\\file1.txt", FileMode.OpenOrCreate, FileAccess.ReadWrite);
            StreamWriter sw = new StreamWriter(fs);
            sw.WriteLine("Hello Everyone, This is File1 contents.");
            sw.Close();
            fs.Close();
            path = "c:\\sample1";
            Directory.CreateDirectory(path);
            fs = new FileStream(path + "\\file2.txt", FileMode.OpenOrCreate, FileAccess.ReadWrite);
            sw = new StreamWriter(fs);
            sw.WriteLine("Hello Everyone, This is File2 contents.");
            sw.Close();
            fs.Close();
            File.Move("C:\\sample\\file1.txt", "C:\\sample1\\file1.txt");
            File.Delete("C:\\sample\\file1.txt");
            File.Move("C:\\sample1\\file2.txt", "C:\\sample\\file2.txt");
            File.Delete("C:\\sample1\\file2.txt");
        }
    }
}