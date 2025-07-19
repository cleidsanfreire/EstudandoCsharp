using ExerciceFixacao.Entities;
using System.Globalization;

namespace ExerciceFixacao
{
    class Program
    {
        static void Main(string[] args)
        {
            List<Product> listProducts = new List<Product>();

            Console.Write("Enter the number of products: ");
            int n = int.Parse(Console.ReadLine());

            for (int i = 1; i <= n; i++)
            {
                Console.WriteLine($"Product #{i} data:");
                Console.Write("Common, used or imported (c/u/i)? ");
                char ch = char.Parse(Console.ReadLine());
                Console.Write("Name: ");
                string name = Console.ReadLine();
                Console.Write("Price: ");
                double value = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

                if (ch == 'c')
                {
                    listProducts.Add(new Product(name, value));
                }
                else if (ch == 'u')
                {
                    Console.Write("Manufacturedate (DD/MM/YYYY): ");
                    DateTime date = DateTime.Parse(Console.ReadLine());
                    listProducts.Add(new UsedProduct(name, value, date));
                }
                else if (ch == 'i')
                {
                    Console.Write("Customs fee: ");
                    double customs = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
                    listProducts.Add(new ImportedProduct(name, value, customs));
                }
                else
                {
                    Console.WriteLine("Letra digitada errada!");
                }
            }

            Console.WriteLine("\nPRICE TAGS:");

            foreach (Product p in listProducts)
            {
                Console.WriteLine(p.PriceTag());
            }
        }
    }
}