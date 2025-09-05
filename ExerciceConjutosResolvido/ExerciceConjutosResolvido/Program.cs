using ExerciceConjutosResolvido.Entites;

namespace ExerciceConjutosResolvido
{
    class Program
    {
        static void Main(string[] args)
        {
            HashSet<LogRecord> set = new HashSet<LogRecord>();

            Console.Write("Enter file full path: ");
            string path = Console.ReadLine();

            try
            {
                using (StreamReader sr = File.OpenText(path))
                {
                    while (!sr.EndOfStream)
                    {
                        string[] line = sr.ReadLine().Split(' ');
                        string name = line[0];
                        DateTime time = DateTime.Parse(line[1]);
                        set.Add(new LogRecord(name, time));

                    }
                    Console.WriteLine("Total users: " + set.Count);
                }
            }
            catch (IOException ex)
            {
                Console.WriteLine("Test");
                Console.WriteLine(ex.Message);
            }
        }
    }
}