using RestricoesGenerics.Services;
using System.Numerics;

namespace RestricoesGenerics
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Enter N: ");
            int n = int.Parse(Console.ReadLine());

            List<int> list = new List<int>();

            for (int i = 0; i < n; i++)
            {
                int number = int.Parse(Console.ReadLine());
                list.Add(number);
            }

            CalculateService cs = new CalculateService();

            int max = cs.Max(list);

            Console.WriteLine("Max:");
            Console.WriteLine(max);
        }
    }
}
