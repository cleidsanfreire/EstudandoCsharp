using System;
using System.Globalization;
using System.Security.Cryptography;

namespace ExerciciosPessoaOO
{
    class Program
    {
        static void Main(string[] args)
        {
            Funcionarios f1 = new Funcionarios();
            Funcionarios f2 = new Funcionarios();

            Console.WriteLine("Dados do primeiro funcionário: ");
            Console.Write("Nome: ");
            f1.Nome = Console.ReadLine();
            Console.Write("Salário: ");
            f1.Salario = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

            Console.WriteLine("Dados do segundo funcionário: ");
            Console.Write("Nome: ");
            f2.Nome = Console.ReadLine();
            Console.Write("Salário: ");
            f2.Salario = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

            double salarioMedio = (f1.Salario + f2.Salario) / 2;

            Console.WriteLine($"Salário médio = {salarioMedio.ToString("F2", CultureInfo.InvariantCulture)}");


            //Pessoa p1 = new Pessoa();
            //Pessoa p2 = new Pessoa();

            //Console.WriteLine("Dados da primeira pessoa:");
            //Console.Write("Nome: ");
            //p1.Nome = Console.ReadLine();
            //Console.Write("Idade: ");
            //p1.Idade = int.Parse(Console.ReadLine());

            //Console.WriteLine("Dados da segunda pessoa:");
            //Console.Write("Nome: ");
            //p2.Nome = Console.ReadLine();
            //Console.Write("Idade: ");
            //p2.Idade = int.Parse(Console.ReadLine());

            //if (p1.Idade > p2.Idade)
            //{
            //    Console.WriteLine($"Pessoa mais velha: {p1.Nome}");
            //}
            //else
            //{
            //    Console.WriteLine($"Pessoa mais velha: {p2.Nome}");
            //}
        }
    }
}