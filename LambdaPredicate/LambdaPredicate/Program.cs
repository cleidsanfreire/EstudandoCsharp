using LambdaPredicate.Entities;

namespace LambdaPredicate
{
    class Prgoram
    {
        static void Main(string[] args)
        {
            List<Product> prod = new List<Product>();

            prod.Add(new Product("TV", 900.00));
            prod.Add(new Product("Mouse", 50.00));
            prod.Add(new Product("Tablet", 350.50));
            prod.Add(new Product("HD Case", 80.90));


            prod.RemoveAll(ProductTest);

            foreach (Product p in prod)
            {
                Console.WriteLine(p);
            }
        }

        public static bool ProductTest(Product p)
        {
            return p.Price > 100.0;
        }
    }
}