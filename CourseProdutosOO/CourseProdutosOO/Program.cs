using System;
using System.Globalization;

namespace CourseProdutosOO
{
    class Program
    {
        static void Main(string[] args)
        {
            Produto produto = new Produto("TV", 900,10);

            produto.Nome = "T";

            Console.WriteLine(produto.Nome);
            Console.WriteLine(produto.Preco);
            Console.WriteLine(produto.Quantidade);
        }
    }
}