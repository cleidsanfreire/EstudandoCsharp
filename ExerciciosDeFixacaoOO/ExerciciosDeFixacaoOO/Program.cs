using ExerciciosDeFixacaoOO;
using System;
using System.Diagnostics.Metrics;
using System.Globalization;
using static System.Runtime.InteropServices.JavaScript.JSType;
using System.Runtime.ConstrainedExecution;

namespace ExerciciosDeFixacao
{
    class Program
    {
        static void Main(string[] args)
        {
            //EXERCÍCIO 01
            Retangulo r = new Retangulo();

            Console.WriteLine("Entre a largura e altura do retângulo: ");
            Console.Write("Largura: ");
            r.Largura = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
            Console.Write("Altura: ");
            r.Altura = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

            Console.WriteLine(r);

            //EXERCÍCIO 02

            Funcionario f = new Funcionario();
            Console.WriteLine("Digite o nome, salario e imposto: ");
            Console.Write("Nome: ");
            f.Nome = Console.ReadLine();
            Console.Write("Salário Bruto: ");
            f.SalarioBruto = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
            Console.Write("Imposto: ");
            f.Imposto = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

            Console.WriteLine("Funcionário: " + f);

            Console.Write("Digite a porcentagem para aumentar o salário: ");
            double porcentagem = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
            f.AumentarSalario(porcentagem);

            //EXERCÍCIO 03

            Aluno a = new Aluno();
            Console.Write("Nome do aluno: ");
            a.Nome = Console.ReadLine();
            Console.WriteLine("Digite as três notas do aluno: ");
            a.N1 = double.Parse(Console.ReadLine());
            a.N2 = double.Parse(Console.ReadLine());
            a.N3 = double.Parse(Console.ReadLine());
            Console.WriteLine(a);

            if (a.Aprovado())
            {
                Console.WriteLine("APROVADO!");
            }else
            {
                Console.WriteLine($"REPROVADO\n" +
                    $"FALTARAM {a.NotaRestante().ToString("F2", CultureInfo.InvariantCulture)} PONTOS");
            }
        }
    }
}