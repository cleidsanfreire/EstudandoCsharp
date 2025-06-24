using System;
using System.Globalization;

namespace TestesExercices
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Entre com o Numero da conta: ");
            int numero = int.Parse(Console.ReadLine());
            Console.Write("Entre com o nome do Titular: ");
            string titular = Console.ReadLine();
            Console.Write("Deseja depositar um deposito inicial? (s/n) ");
            char depositoInicial = char.Parse(Console.ReadLine().ToUpper());

            ContaBancaria conta;

            if (depositoInicial.Equals('S'))
            {
                Console.Write("Insira o valor de Deposito Inicial: ");
                double valor = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

                conta = new ContaBancaria(numero, titular, valor);
            }
            else
            {
                conta = new ContaBancaria(numero, titular);
            }

            Console.WriteLine($"\nDados da conta: \n{conta}");

            Console.Write("\nDeseja fazer um depoisto (D), Saque (S) ou Finalizar (F): ");
            char opcao = char.Parse(Console.ReadLine().ToUpper());

            while (true)
            {
                if (opcao.Equals('D'))
                {
                    Console.Write("\nEntre o valor de deposito: ");
                    double quantia = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

                    conta.Deposito(quantia);
                }
                else if (opcao.Equals('S'))
                {
                    Console.Write("\nEntre o valor de saque: ");
                    double quantia = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

                    conta.Saque(quantia);
                }
                else
                {
                    Console.WriteLine("\nSistema finalizado!!");
                    break;
                }

                Console.WriteLine($"\nDados Atualizados: \n{conta}");
                Console.WriteLine("\nDeseja fazer outra operação? depoisto (D), Saque (S) ou Finalizar (F): ");
                opcao = char.Parse(Console.ReadLine().ToUpper());
            }
        }
    }
}