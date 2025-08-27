using RestricoesGenerics.Entities;
using RestricoesGenerics.Services;
using System.Globalization;

namespace RestricoesGenerics
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Enter N: ");
            int n = int.Parse(Console.ReadLine());

            List<Product> list = new List<Product>();

            for (int i = 0; i < n; i++)
            {
                string[] vect = Console.ReadLine().Split(',');
                string name = vect[0];
                double price = double.Parse(vect[1], CultureInfo.InvariantCulture);
                list.Add(new Product(name, price));
            }

            CalculateService cs = new CalculateService();

            Product max = cs.Max(list);

            Console.WriteLine("Max:");
            Console.WriteLine(max);
        }
    }
}
