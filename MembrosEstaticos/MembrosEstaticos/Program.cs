using System;
using System.Globalization;

namespace MembrosEstaticos
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Qual é a Cotação do Dólar? ");
            double dolar = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
            Console.Write("Quantos dólares você vai comprar? ");
            double valorComprar = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

            Console.WriteLine($"Valor a ser pago em reais = {ConversorDeMoeda.Conversor(dolar, valorComprar).ToString("F2", CultureInfo.InvariantCulture)}");
        }
    }
}