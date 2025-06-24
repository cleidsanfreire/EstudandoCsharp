using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TestesExercices
{
    internal class ContaBancaria
    {
        public int Numero { get; private set; }
        public string Titular { get; set; }
        public double Saldo { get; private set; }

        public ContaBancaria(int numero, string titular)
        {
            Numero = numero;
            Titular = titular;
        }

        public ContaBancaria(int numero, string titular, double saldo) : this(numero, titular)
        {
            Saldo = saldo;
        }

        public void Deposito(double quantia)
        {
            if (quantia > 0.0)
            {
                Saldo += quantia;
                Console.WriteLine("Deposito realizado com sucesso!");
            }
            else
            {
                Console.WriteLine("Valor invalido insira um valor acima de R$ 0.00");
            }
        }

        public void Saque(double quantia)
        {
            if (quantia > 0.00 && quantia <= Saldo)
            {
                Saldo -= quantia;
            }else
            {
                Console.WriteLine("Quantia indisponivel");
            }
        }


        public override string ToString()
        {
            return $"Numero: {Numero}, " +
                    $"Titular: {Titular}, " +
                    $"Saldo disponivel: {Saldo.ToString("F2", CultureInfo.InvariantCulture)}";
        }
    }
}
