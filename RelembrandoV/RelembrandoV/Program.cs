using System;

namespace RelembrandoV
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Digite quantos quartos seram alugados: ");
            int n = int.Parse(Console.ReadLine());

            Quartos[] quartos = new Quartos[10];

            for (int i = 1; i <= n; i++)
            {
                Console.WriteLine("Alugel #"+i);
                Console.Write("Nome: "); string name = Console.ReadLine();
                Console.Write("Email: "); string email = Console.ReadLine();
                Console.Write("Quarto a ser alugado: "); int quarto = int.Parse(Console.ReadLine());

                quartos[quarto] = new Quartos(name, email);
            }

            Console.WriteLine("Quartos Ocupados:");

            for (int i = 1; i < quartos.Length; i++)
            {
                if (quartos[i] != null)
                {
                    Console.WriteLine(i + ": " + quartos[i]);
                }
                else
                {
                    Console.WriteLine(i + ": Vazio");
                }
            }
        }
    }
}