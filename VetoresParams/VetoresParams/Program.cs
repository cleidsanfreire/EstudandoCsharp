using System;

namespace VetoresParams
{
    class Program
    {
        static void Main(string[] args)
        {
            double num = Calculator.Sum(new int[] { 1, 2 });
            double num1 = Calculator.Sum(1, 2,3,5,7,2,6,24,62,24,2626,2424,78);

            Console.WriteLine(num);
            Console.WriteLine(num1);
        }
    }
}