using System;
using System.Globalization;

namespace ProdutosOO
{
    class Program
    {
        static void Main(string[] args)
        {
            Produto p = new Produto();

            Console.WriteLine("Entre com os dados do Produto: ");
            Console.Write("Nome: ");
            p.Nome = Console.ReadLine();
            Console.Write("Preço: ");
            p.Preco = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
            Console.Write("Quantidade: ");
            p.Quantidade = int.Parse(Console.ReadLine());

            Console.WriteLine("\nDados do Produto: " + p);

            Console.Write("\nDigite o número de produtos a ser adicionado ao estoque: ");
            int addEstoque = int.Parse(Console.ReadLine());
            p.AdicionarProdutos(addEstoque);

            Console.Write("\nDigite o número de produtos a ser removido do estoque: ");
            int removeEstoque = int.Parse(Console.ReadLine());
            p.RemoverProdutos(removeEstoque);
        }
    }
}