using ExercicioFixacaoComposicao.Entities;
using ExercicioFixacaoComposicao.Entities.Enums;
using System;
using System.Globalization;

namespace ExercicioFixacaoComposicao
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter cliente data:");
            Console.Write("Name: ");
            string name = Console.ReadLine();
            Console.Write("Email: ");
            string email = Console.ReadLine();
            Console.Write("Birthdate (DD/MM/YYYY): ");
            DateTime date = DateTime.Parse(Console.ReadLine());

            Client c1 = new Client(name, email,date);

            Console.WriteLine("\nEnter order data:");
            Console.Write("Status: ");
            OrderStatus status = Enum.Parse<OrderStatus>(Console.ReadLine());
            
            Order or = new Order(DateTime.Now,status,c1);

            Console.Write("\nHow many items to this order? ");
            int n = int.Parse(Console.ReadLine());

            for (int i = 1; i <= n; i++)
            {
                Console.WriteLine($"Enter #{i} item data:");
                Console.Write("Product name: ");
                string nameProduct = Console.ReadLine();
                Console.Write("Product price: ");
                double priceProduct = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
                Console.Write("Quantity; ");
                int quantity = int.Parse(Console.ReadLine());

                Product pro = new Product(nameProduct, priceProduct);
                OrderItem item = new OrderItem(quantity, priceProduct,pro);

                or.AddItem(item);
            }

            Console.WriteLine("\nORDER SUMMARY:");
            Console.WriteLine(or);

        }
    }
}