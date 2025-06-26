using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace VetoresParams
{
    internal class Calculator
    {

        public static double Sum(params int[] numeros)
        {

            double sum = 0;

            for (int i = 0; i < numeros.Length; i++)
            {
                sum += numeros[i];
            }

            return sum;
        }
    }
}
