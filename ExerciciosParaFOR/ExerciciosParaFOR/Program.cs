using System;
using System.Drawing;

namespace ExerciciosParaFor
{
    class Program
    {
        static void Main(string[] args)
        {
            //Exercício 01
            //Leia um valor inteiro X(1 <= X <= 1000).Em seguida mostre os ímpares de 1 até X, um valor por linha, inclusive o
            //X, se for o caso. 

            Console.Write("Digite um valor inteiro:");
            int x = int.Parse(Console.ReadLine());

            for (int i = 0; i <= x; i++)
            {
                if (i % 2 != 0)
                {
                    Console.WriteLine(i);
                }
            }

            //Exercício 02
            //Exercício 03
            //Exercício 04
            //Exercício 05
            //Exercício 06
            //Exercício 07
        }
    }
}