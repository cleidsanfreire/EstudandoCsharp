using Enumeracoes.Entities;
using Enumeracoes.Entities.Enums;

namespace Enumeracoes
{
    class Program
    {
        static void Main(string[] args)
        {
            Order order = new Order
            {
                Id = 1080,
                Moment = DateTime.Now,
                Status = OrderStatus.PendingPayment
            };

            Console.WriteLine("0 = PendingPayment\n1 = Processing\n2 = Shipped\n3 = Delivered");
            int op = int.Parse(Console.ReadLine());

            string txt = OrderStatus.PendingPayment.ToString();
            OrderStatus os = new OrderStatus();
            switch (op)
            {
                case 0:
                    os = Enum.Parse<OrderStatus>("PendingPayment");
                    break;
                case 1:
                    os = Enum.Parse<OrderStatus>("Processing");
                    break;
                case 2:
                    os = Enum.Parse<OrderStatus>("Shipped");
                    break;
                case 3:
                    os = Enum.Parse<OrderStatus>("Delivered");
                    break;
                default:
                    Console.WriteLine("Numero errado");
                    break;
            }
            Console.WriteLine(txt);
            Console.WriteLine(os);
            Console.WriteLine(order);

        }
    }
}
