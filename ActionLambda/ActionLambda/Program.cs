using ActionLambda.Entities;

namespace ActionLambda
{
    class Program
    {
        static void Main(string[] args)
        {
            List<Product> list = new List<Product>();

            list.Add(new Product("Tv", 900.0));
            list.Add(new Product("Mouse", 50.0));
            list.Add(new Product("Tablet", 350.50));
            list.Add(new Product("HD Case", 80.90));

            //Action<Product> act = ProductAction;
            //Action<Product> act = p => { p.Price += p.Price * 0.1; };

            list.ForEach(p => p.Price += p.Price * 0.1);

            foreach (Product p in list)
            {
                Console.WriteLine(p);
            }
        }

        //public static void ProductAction(Product p)
        //{
        //    p.Price += p.Price * 0.1;
        //}
    }
}