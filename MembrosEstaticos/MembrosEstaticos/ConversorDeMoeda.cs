using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MembrosEstaticos
{
    internal class ConversorDeMoeda
    {
        public static double Iof = 0.06;
        public static double Conversor(double dolar, double valorComprar)
        {
            double total = valorComprar * dolar;
            return total + total * Iof;
        }
    }
}
