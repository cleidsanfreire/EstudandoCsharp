using System;
using System.Drawing;
using System.Globalization;

namespace BancoExercicio
{
    class Program
    {
        static void Main(string[] args)
        {
            ContaBancaria conta;
            Console.Write("Entre o número da conta: ");
            int numero = int.Parse(Console.ReadLine());
            Console.Write("Entre o titular da conta: ");
            string titular = Console.ReadLine();
            Console.Write("Haverá depósito inicial (s/n)? ");
            char depositoInicial = char.Parse(Console.ReadLine().ToUpper());


            double valor = 0;

            if (depositoInicial.Equals('S'))
            {
                Console.Write("Entre o valor de depósito inicial: ");
                valor = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

                conta = new ContaBancaria(numero, titular, valor);

            }
            else
            {
                conta = new ContaBancaria(numero, titular);
            }


            Console.WriteLine("\nDados da Conta:\n" + conta);

            Console.Write("\nEntre um valor para depósito: ");
            valor = double.Parse(Console.ReadLine(),CultureInfo.InvariantCulture);
            conta.Deposito(valor);
            Console.WriteLine("\nDados da conta atualizados:\n" + conta);

            Console.Write("\nEntre um valor para saque: ");
            valor = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
            conta.Saque(valor);
            Console.WriteLine("\nDados da conta atualizados:\n" + conta);


        }
    }
}