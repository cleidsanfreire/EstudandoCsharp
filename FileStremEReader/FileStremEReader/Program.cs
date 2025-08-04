namespace FileStremEReader
{
    class Program
    {
        static void Main(string[] args)
        {
            string path = @"C:\Users\loock\Downloads\file1.txt";
            StreamReader sr = null;
            try
            {
                sr = File.OpenText(path);

                while (!sr.EndOfStream)
                {
                    string line = sr.ReadLine();
                    Console.WriteLine(line);
                }
            }
            catch (IOException e)
            {
                Console.WriteLine(e.Message);
            }
            finally
            {
                if (sr != null) sr.Close();
            }
        }
    }
}