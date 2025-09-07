using FuncSelect.Entities;

namespace FuncSelect
{
    class Program
    {
        static void Main(string[] args)
        {
            List<Product> prod = new List<Product>();

            prod.Add(new Product("Tv", 900.0));
            prod.Add(new Product("Mouse", 50.50));
            prod.Add(new Product("Tablet", 350.50));
            prod.Add(new Product("Notebook", 1300.90));

            //Func<Product, string> func = ProductUpper;

            //List<string> result = prod.Select(ProductUpper).ToList();
            //List<string> result = prod.Select(func).ToList();
            List<string> result = prod.Select(p => p.Name.ToUpper()).ToList();

            foreach (string item in result)
            {
                Console.WriteLine(item);
            }
        }

        //public static string ProductUpper(Product p)
        //{
        //    return p.Name.ToUpper();
        //}
    }
}