using System;

namespace TiposValor
{
    class Program
    {
       static void Main(string[] args)
        {
            //Point p;
            //p.X = 10;
            //p.Y = 10;
            //Console.WriteLine(p);

            //Point p = new Point();
            //Console.WriteLine(p);

            Point p1 , p2;

            p1 = new Point();

            p1.X = 25;
            p1.Y = 35;

            p2 = p1;

            Console.WriteLine(p1);

            Console.WriteLine();

            Console.WriteLine(p2);
        }
    }
}