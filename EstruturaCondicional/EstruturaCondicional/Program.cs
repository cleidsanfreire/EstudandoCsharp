using System;

namespace EstruturaCondicional
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Qual a hora atual?");
            int hora = int.Parse(Console.ReadLine());

            if (hora < 12)
            {
                Console.WriteLine("Bom dia!");
            } else if (hora < 18)
            {
                Console.WriteLine("Boa tarde!");
            }else
            {
                Console.WriteLine("Boa noite!");
            }


            //Console.WriteLine("Digite um numero inteiro:");
            //int num = int.Parse(Console.ReadLine());

            //int resutl = num % 2;

            //if (resutl == 0 )
            //{
            //    Console.WriteLine("Par");
            //} else
            //{
            //    Console.WriteLine("Impar");
            //}
        }
    }
}