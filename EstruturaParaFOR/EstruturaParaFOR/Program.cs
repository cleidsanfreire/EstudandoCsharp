using System;

namespace EstruturaParaFOR
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Quantos números inteiros você vai digitar? ");
            int n = int.Parse(Console.ReadLine());
            int a = 0;

            for (int i = 1; i <= n; i++)
            {
                Console.Write($"Valor #{i}: ");
                a += int.Parse(Console.ReadLine());
            }


            Console.WriteLine($"Soma = {a}");
        }
    }
}