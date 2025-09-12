using ExercicioLambdaLinqResolvido.Entities;
using System.Globalization;

namespace ExercicioLambdaLinqResolvido
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Enter full path file: ");
            string path = Console.ReadLine();

            List<Product> prod = new List<Product>();

            try
            {
                using (StreamReader sr = File.OpenText(path))
                {
                    while (!sr.EndOfStream)
                    {
                        string[] line = sr.ReadLine().Split(',');
                        string name = line[0];
                        double price = double.Parse(line[1], CultureInfo.InvariantCulture);
                        prod.Add(new Product(name, price));
                    }
                }

                var aveg = prod.Select(p => p.Price).DefaultIfEmpty(0.0).Average();

                Console.WriteLine("Average price: " + aveg.ToString("F2", CultureInfo.InvariantCulture));
                
                //var names = prod.Where(p => p.Price < aveg).OrderByDescending(p => p.Name).Select(p => p.Name);
                var prodAveg = from p in prod
                               where p.Price < aveg
                               orderby p.Name descending
                               select p.Name;

                foreach (string name in prodAveg)
                {
                    Console.WriteLine(name);
                }
                

            }
            catch (IOException e)
            {
                Console.WriteLine(e.Message);
            }
        }
    }
}