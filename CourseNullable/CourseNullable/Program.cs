using System;

namespace CourseNullable
{
    class Program
    {
        static void Main(string[] args)
        {
            // Nullable<double> x = null;
            // Outra maneira de fazer.
            double? x = null;

            double? y = 10.0;

            Console.WriteLine(x.GetValueOrDefault()); // Pega o valor da variavel ou pega o valor padrao 
            Console.WriteLine(y.GetValueOrDefault()); // Pega o valor da variavel ou pega o valor padrao 

            Console.WriteLine(x.HasValue); // verificar se tem valor(true) ou nao (falso)
            Console.WriteLine(y.HasValue);

            if (x.HasValue)
                Console.WriteLine(x.Value);
            else
                Console.WriteLine("X is null");

            if (y.HasValue)
                Console.WriteLine(y.Value);
            else
                Console.WriteLine("Y is null");

            // Operadores Coacilensios

            double? xg = null;
            double? f = 10.0;

            double a = xg ?? 5;
            double b = f ?? 5;

            Console.WriteLine(a);
            Console.WriteLine(b);
        }
    }
}