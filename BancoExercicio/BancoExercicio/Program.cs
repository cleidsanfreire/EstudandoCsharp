using System;
using System.Drawing;
using System.Globalization;

namespace BancoExercicio
{
    class Program
    {
        static void Main(string[] args)
        {
            ContaBancaria cB;
            Console.Write("Entre o número da conta: ");
            int numero = int.Parse(Console.ReadLine());
            Console.Write("Entre o titular da conta: ");
            string titular = Console.ReadLine();
            Console.Write("Haverá depósito inicial (s/n)? ");
            string depositoInicial = Console.ReadLine().ToUpper();


            double valor = 0;

            if (depositoInicial.Equals("S"))
            {
                Console.Write("Entre o valor de depósito inicial: ");
                valor = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

                cB = new ContaBancaria(numero, titular, valor);

            }
            else
            {
                cB = new ContaBancaria(numero, titular);
            }


            Console.WriteLine("\nDados da Conta:\n" + cB);

            Console.Write("\nEntre um valor para depósito: ");
            valor = double.Parse(Console.ReadLine(),CultureInfo.InvariantCulture);
            cB.Deposito(valor);
            Console.WriteLine("\nDados da conta atualizados:\n" + cB);

            Console.Write("\nEntre um valor para saque: ");
            valor = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
            cB.Saque(valor);
            Console.WriteLine("\nDados da conta atualizados:\n" + cB);


        }
    }
}