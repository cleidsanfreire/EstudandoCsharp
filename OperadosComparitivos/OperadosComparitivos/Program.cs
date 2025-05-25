using System;

namespace OperadosComparativos
{
    class Program
    {
        static void Main(string[] args)
        {
            int a = 10;
            int g = 20;

            bool b1 = a < g;

            Console.WriteLine(b1);

            bool b2 = a <= g;
            bool b3 = a >= g;
            bool b4 = a == a;
            bool b5 = a != a;
            bool b6 = a != g;

            Console.WriteLine(b2);
            Console.WriteLine(b3);
            Console.WriteLine(b4);
            Console.WriteLine(b5);
            Console.WriteLine(b6);
            Console.WriteLine(" ----------------------------------- ");

            bool g2 = 2 > 3 && 4 != 5; // false
            bool g3 = 2 > 3 || 4 != 5; // true
            bool g4 = !(2 > 3) || 4 != 5; // true

            Console.WriteLine(g2);
            Console.WriteLine(g3);
            Console.WriteLine(g4);

            Console.WriteLine(" ------------------------------------- ");
            bool g5 = g3 || g4 && g2; // true

            Console.WriteLine(g5);
        }
    }
}