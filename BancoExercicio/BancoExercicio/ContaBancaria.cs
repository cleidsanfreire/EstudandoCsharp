using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Net.Mime.MediaTypeNames;

namespace BancoExercicio
{
    internal class ContaBancaria
    {
        

        public int Numero { get; set; }
        public string Titular { get; set; }
        public double Saldo { get; private set; }

        public ContaBancaria()
        {
        }

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
            if (quantia > 0)
            {
                Saldo += quantia;
            }
            else
            {
                Console.WriteLine("Digite um valor de deposito valido.");
            }
        }

        public void Saque(double quantia)
        {
            if (Saldo > 0 && quantia <= Saldo)
            {
                Saldo = (Saldo - quantia) - 5;
            }
            else
            {
                Console.WriteLine("Saldo Insuficiente");
            }
        }

        public override string ToString()
        {
            return $"Conta {Numero}, Titular: {Titular}, Saldo: $ {Saldo.ToString("F2", CultureInfo.InvariantCulture)}";
        }
    }
}
