namespace UsingStremReader
{
    class Program
    {
        static void Main(string[] args)
        {
            string sourcePath = @"C:\Users\loock\Downloads\file1.txt";
            string targetPath = @"C:\Users\loock\Downloads\file3.txt";
            try
            {
                string[] line = File.ReadAllLines(sourcePath);

                using (StreamWriter sw = File.AppendText(targetPath))
                {
                   foreach (string l in line)
                    {
                        sw.WriteLine(l.ToUpper());
                    }
                }

            }
            catch (IOException e)
            {
                Console.WriteLine(e.Message);
            }
        }
    }
}

