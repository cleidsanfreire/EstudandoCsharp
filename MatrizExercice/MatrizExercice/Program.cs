using System;

namespace MatrizExercice
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Digite dois numeros inteiros: ");
            Console.Write("Linhas: "); int nL = int.Parse(Console.ReadLine());
            Console.Write("Colunas: "); int nC = int.Parse(Console.ReadLine());

            int[,] mat = new int[nL, nC];

            for (int i = 0; i < nL; i++)
            {
                string[] values = Console.ReadLine().Split(' ');
                for (int j = 0; j < nC; j++)
                {
                    mat[i, j] = int.Parse(values[j]);
                }
            }

            Console.Write("\nDigite um numero inteiro: ");
            int x = int.Parse(Console.ReadLine());

            for (int i = 0; i < nL; i++)
            {
                for (int j = 0; j < nC; j++)
                {
                    if (mat[i, j] == x)
                    {
                        Console.WriteLine("Position " + i + "," + j);
                       if (j < nC - 1)
                        {
                            Console.WriteLine("Right: " + mat[i,j+1]);
                        }
                       if (j > 0)
                        {
                            Console.WriteLine("Left: " + mat[i,j-1]);
                        }
                       if (i > 0)
                        {
                            Console.WriteLine("Up: " + mat[i-1,j]);
                        }
                       if (i < nL - 1)
                        {
                            Console.WriteLine("Down: " + mat[i+1,j]);
                        }
                    }
                }
            }
        }
    }
}