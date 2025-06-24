using CourseExercicioDeFixacao;
using System;

namespace CourseExercicioFixacao
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Quantos quartos serão alugados? ");
            int n = int.Parse(Console.ReadLine());

            Quartos[] quartos = new Quartos[10];

            for (int i = 1; i <= n; i++)
            {
                Console.WriteLine($"\nAluguel #{i}");
                Console.Write("Nome: "); string name = Console.ReadLine();
                Console.Write("Email: "); string email = Console.ReadLine();
                Console.Write("Quarto: "); int quartoAlugado = int.Parse(Console.ReadLine());

                quartos[quartoAlugado] = new Quartos(name, email);
            }

            Console.WriteLine("\nQuartos ocupados:");
            for (int i = 0; i <= quartos.Length;i++)
            {
                if (quartos[i] != null)
                {
                    Console.WriteLine(i+": " + quartos[i].ToString());
                }
                else
                {
                    Console.WriteLine(i + " NULL");
                }
            }
        }
    }
}