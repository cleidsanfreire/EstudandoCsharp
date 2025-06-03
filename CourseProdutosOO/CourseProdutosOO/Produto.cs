using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CourseProdutosOO
{
    internal class Produto
    {
        private string _nome;
        public double Preco { get; private set; }
        public int Quantidade { get; private set; }

        public Produto()
        {
        }
        public Produto(string nome, double preco) : this()
        {
            _nome = nome;
            Preco = preco;
        }

        public Produto(string nome, double preco, int quantidade) : this(nome, preco)
        {
            Quantidade = quantidade;
        }

        public string Nome
        {
            get { return _nome; }
            set
            {
                if (value != null && value.Length > 1)
                {
                    _nome = value;
                }
            }
        }

        
        public double ValorTotalEmEstoque()
        {
            return Preco * Quantidade;
        }

        public void AdicionarProdutos(int quantidade)
        {
            Quantidade += quantidade;
            Console.WriteLine($"\nDados Atualizados: " + ToString());
        }
        public void RemoverProdutos(int quantidade)
        {
            Quantidade -= quantidade;
            Console.WriteLine($"\nDados Atualizados: " + ToString());
        }

        public override string ToString()
        {
            return $"{_nome}, R$ {Preco.ToString("F2", CultureInfo.InvariantCulture)}, " +
                   $"{Quantidade} unidades," +
                   $"Total: $ {ValorTotalEmEstoque().ToString("F2", CultureInfo.InvariantCulture)}";
        }


    }
}
