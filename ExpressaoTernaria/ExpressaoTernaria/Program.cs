using System;
using System.Globalization;
using System.Linq.Expressions;

namespace ExpressaoTernaria
{
    class Program
    {
        static void Main(string[] args)
        {
            double preco = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

            //double desconto;

            //if (preco < 20)
            //{
            //    desconto = preco * 0.1;
            //}else
            //{
            //    desconto = preco * 0.05;
            //}

            //Sintaxe alternativa - expressão condicionalTernaria
            double desconto = (preco < 20) ? preco * 0.1 : preco * 0.05;

            Console.WriteLine(desconto);
        }
    }
}