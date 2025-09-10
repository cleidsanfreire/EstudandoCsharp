using RevisaoLambda.Entities;

namespace RevisaoLambda
{
    class Program
    {
        static void Main(string[] args)
        {
            List<Product> listProd = new List<Product>();

            listProd.Add(new Product("RTX 4060", 2400.00));
            listProd.Add(new Product("Mouse", 80.00));
            listProd.Add(new Product("Tablet", 500.00));
            listProd.Add(new Product("Suporte", 30.00));
            listProd.Add(new Product("Notebook", 2900.00));

            // Percorrendo a lista 1 por 1 e aplicando a logica.
            listProd.ForEach(p => p.Price += p.Price * 0.1);

            foreach (Product p in listProd)
            {
                Console.WriteLine(p);
            }

            // Removendo tudo da list de acordo com a logica
            listProd.RemoveAll(p => p.Price > 100.0);

            foreach (Product p in listProd)
            {
                Console.WriteLine(p);
            }

            // Aplicando a  logica de um comando
            List<string> result = listProd.Select(p => p.Name.ToUpper()).ToList();

            foreach (string item in result)
            {
                Console.WriteLine(item);
            }
        }
    }
}