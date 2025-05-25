using System;
using System.Globalization;

namespace EnquantoWhile
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Digite um número: ");
            double num = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

            bool numNeg = false;

            while (!numNeg)
            {
                if (num < 0)
                {
                    Console.WriteLine("Número negativo!");
                    numNeg = true;
                    break;
                }
                else
                {
                    double sqrtNum = Math.Sqrt(num);
                    Console.WriteLine(sqrtNum.ToString("F3", CultureInfo.InvariantCulture));
                }
                Console.Write("Digite outro número: ");
                num = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
            }


            // *------- OUTRA MANEIRA --------*

            //    Console.Write("Digite um número: ");
            //    double x1 = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

            //    while (x1 >= 0.0)
            //    {   
            //        double raiz = Math.Sqrt(x1);
            //        Console.WriteLine(raiz);
            //        Console.Write("Digite outro número: ");
            //        x1 = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
            //    }

            //    Console.Write("Numero Negativo!");
            //}

        }
}