using DemoLinqPT1.Entities;
using System.Globalization;

namespace DemoLinqPT1
{
    class Program
    {
        static void Print<T>(string message, IEnumerable<T> collection)
        {
            Console.WriteLine(message);
            foreach (var obj in collection) Console.WriteLine(obj);
            Console.WriteLine();
        }
        static void Main(string[] args)
        {
            Category c1 = new Category() { ID = 1, Name = "Tools", Tier = 2 };
            Category c2 = new Category() { ID = 2, Name = "Cumputers", Tier = 1 };
            Category c3 = new Category() { ID = 3, Name = "Eletronics", Tier = 1 };

            List<Product> products = new List<Product>()
            {
                new Product(1,"Computer",1100.00,c2),
                new Product(2,"Hammer",90.00,c1),
                new Product(3,"TV",1700.00,c3),
                new Product(4,"Notebook",1300.00,c2),
                new Product(5,"Saw", 80.00,c1),
                new Product(6,"Tablet",700.00,c2),
                new Product(7,"Camera",700.00,c3),
                new Product(8,"Printer",350.00,c3),
                new Product(9,"MacBook",1800.00,c2),
                new Product(10,"Sound Bar",700.00,c3),
                new Product(11,"Level",70.00,c1)
            };
            // Where e um filtro que retorna apenas o que e descrito no lambda.
            var r1 = products.Where(p => p.Category.Tier == 1 && p.Price < 900.0);
            Print("TIER 1 AND PRICE < 900.0", r1);


            var r2 = products.Where(p => p.Category.Name == "Tools").Select(p => p.Name);   
            Print("NAMES FROM PRODUCTS FROM TOOLS", r2);

            var r3 = products.Where(p => p.Name[0] == 'C').Select(p => new { p.Name, p.Price, CategoryName = p.Category.Name });
            Print("Names Started With 'C' AND Anonymous Object", r3 );

            var r4 = products.Where(p => p.Category.Tier == 1).OrderBy(p => p.Price).ThenBy(p => p.Name);
            Print("TIER 1 ORDER BY PRICE THEN BY NAME", r4);

            var r5 = r4.Skip(2).Take(4);
            Print("TIER 1 ORDER BT PRICE THEN BY NAME SKIP 2 TAKE 4", r5 );

            //var r6 = products.First();
            var r6 = products.FirstOrDefault();
            Console.WriteLine("First test1: " + r6);
            var r7 = products.Where(p => p.Price > 3000.0).FirstOrDefault();
            Console.WriteLine("First test2: " + r7);
            Console.WriteLine();

            var r8 = products.Where(p => p.ID == 3).SingleOrDefault();
            Console.WriteLine("Single or default test1: " + r8);

            var r9 = products.Where(p => p.ID == 30).SingleOrDefault();
            Console.WriteLine("Single or default test2: " + r9);
            Console.WriteLine();

            var r10 = products.Max(p => p.Price);
            Console.WriteLine("Max price: " + r10);
            var r11 = products.Min(p => p.Price);
            Console.WriteLine("Min price: " + r11);
            var r12 = products.Where(p => p.Category.ID == 1).Sum(p => p.Price);
            Console.WriteLine("Category 1 Sum price: " + r12);
            var r13 = products.Where(p => p.Category.ID == 1).Average(p => p.Price);
            Console.WriteLine("Category 1 Avarage prices: " + r13);

            // Select projeta (extrai) apenas o valor da propriedade "Price" de cada "produto" filtrado.
            //Ou seja, ele transforma a lista de "Product" em uma lista de "Price" (geralmente decimal, double ou outro tipo numérico).
            var r14 = products.Where(p => p.Category.ID == 5).Select(p => p.Price).DefaultIfEmpty(0.0).Average();
            Console.WriteLine("Category 5 Avarage prices: " + r14);
            Console.WriteLine();

            var r16 = products.GroupBy(p => p.Category);
            foreach (IGrouping<Category, Product> group in r16)
            {
                Console.WriteLine("Category " + group.Key.Name + ": ");
                foreach (Product p in group)
                {
                    Console.WriteLine(p);
                }
                Console.WriteLine();
            }
        }
    }
}