using System;
using System.Collections;

namespace TesteVagaEstagioJava
{
    class Program
    {
        static void Main(string[] args)
        {
            int nRegistro = int.Parse(Console.ReadLine());

            string[] eventos = Console.ReadLine().Split(" ");

            int CargaBateriaInicial = 50;


            for (int i = 0; i < nRegistro; i++)
            {
                int evento = int.Parse(eventos[i]);
                if (evento > 0)
                {
                    // Positivo carrega
                    CargaBateriaInicial += evento;
                    if (CargaBateriaInicial > 100)
                    {
                        CargaBateriaInicial = 100;
                    }
                }
                else
                {
                    // Negativo descarrega
                    int descarregando = evento * -1;
                    CargaBateriaInicial -= descarregando;

                }
            }

            Console.WriteLine(CargaBateriaInicial);
        }
    }
}