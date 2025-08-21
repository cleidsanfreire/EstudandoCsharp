using InterfaceComparable.Entities;

namespace InterfaceComparable
{
    class Program
    {
        static void Main(string[] args)
        {
            string path = @"C:\Users\loock\Downloads\Curso C#\file.txt";

            try
            {
                using (StreamReader sr = File.OpenText(path))
                {
                    List<Employee> list = new List<Employee>();
                    while (!sr.EndOfStream)
                    {
                        list.Add(new Employee(sr.ReadLine()));
                    }
                    list.Sort();
                    foreach (Employee emp in list)
                    {
                        Console.WriteLine(emp); 
                    }
                }
            }
            catch (IOException ex)
            {
                Console.WriteLine("An error occurred");
                Console.WriteLine(ex.Message);
            }
        }
    }
}