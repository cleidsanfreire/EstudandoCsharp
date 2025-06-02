using System;
using System.Globalization;

namespace CourseProdutosOO
{
    class Program
    {
        static void Main(string[] args)
        {

            Console.WriteLine("Entre com os dados do Produto: ");
            Console.Write("Nome: ");
            string nome = Console.ReadLine();
            Console.Write("Preço: ");
            double preco = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
            Console.Write("Quantidade: ");
            int quantidade = int.Parse(Console.ReadLine());

            Produto p = new Produto(nome, preco,quantidade);

            Produto p2 = new Produto(nome, preco);

            Produto p3 = new Produto()
            {
                Nome = nome,
                Preco = preco,
                Quantidade = quantidade
            };

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