using System;
using System.Globalization;

namespace Saidas
{
    internal class Program
    {
        static void Main(string[] args)
        {

            ////char genero = 'F';
            //int idade = 18;
            //double salario = 150.256236;
            //string name = "Maria";

            ////Console.Write("Bom dia!");
            ////Console.WriteLine("Boa tarde!");
            ////Console.WriteLine("Boa noite!");
            ////Console.WriteLine("-----------------");
            ////Console.WriteLine(genero);
            ////Console.WriteLine(idade);
            ////Console.WriteLine(salario);
            ////Console.WriteLine(name);

            ////Console.WriteLine(salario.ToString("F2"));
            ////Console.WriteLine(salario.ToString("F4"));
            ////Console.WriteLine(salario.ToString("F4", CultureInfo.InvariantCulture));

            //// Utilizando os placeholders {}
            //Console.WriteLine("{0} tem {1} anos e tem o saldo igual a {2:F2} reais.", name, idade, salario);

            //// Utilizando a Interpolação $"{}" // Melhor forma de usar na minha opinão
            //Console.WriteLine($"{name} tem {idade} anos e tem o saldo igual a {salario:F2} reais.");

            //// Utilizando a tecnica mais antiga Concatenação
            //Console.WriteLine(name + " tem " + idade + " anos e tem o saldo igual a " + salario.ToString("F2") + " reais.");

            // Exercicio
            // Em um novo programa, inicie as seguintes variaveis:

            string produto1 = "Computador";
            string produto2 = "Mesa de exritório";

            byte idade = 30;
            int codigo = 5290;
            char genero = 'M';

            double preco1 = 2100.0;
            double preco2 = 650.50;
            double medida = 53.234567;


            Console.WriteLine("Produto:");
            Console.WriteLine($"{produto1}, cujo preço é $ {preco1:F2}");
            Console.WriteLine($"{produto2}, cujo preço é $ {preco2:F2}");

            Console.WriteLine($"Registro: {idade} anos de idade, código {codigo} e genero: {genero}");

            Console.WriteLine("Medida com oito casas decimais: " + medida.ToString("F8"));
            Console.WriteLine($"Arredondando (trés casas decimais): {medida:F3}");
            Console.WriteLine("Separador decimal invariant culture: " + medida.ToString("F3", CultureInfo.InvariantCulture));
        }
    }
}