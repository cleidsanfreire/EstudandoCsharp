using System;
using System.Globalization;

namespace CourseVetores
{
    class Program
    {
        static void Main(string[] args)
        {
            // Parte 1

            //int n = int.Parse(Console.ReadLine());

            //double[] vect = new double[n]; // Aqui vai o tamanho escolhido do vetor , 0,1,5,10,100..... ou uma variavel carregando esse tamanho.

            //for (int i = 0; i < n; i++)
            //{
            //    vect[i] = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture); // adicionando um item ao vetor de posiçao da mesma da variavel interna i
            //}


            //double sum = 0.0; // variavel q vai carregar toda a soma dos numeros do vetor

            //for (int i = 0; i < n; i++)
            //{
            //    sum += vect[i]; // somando a variavel sum os numeros no vetor de acordo com a variavel interna i
            //}

            //double avg = sum / n;
            //Console.WriteLine("AVERAGE HEIGHT = " + avg.ToString("F2", CultureInfo.InvariantCulture));
            
            // Part 2

            int n = int.Parse(Console.ReadLine());

            Product[] prod = new Product[n];

            for (int i = 0; i < n; i++)
            {
                string name = Console.ReadLine();
                double price = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

                prod[i] = new Product { Name = name, Price = price };
            }

            double sum = 0.0;

            for (int i = 0;i < n;i++)
            {
                sum += prod[i].Price;
            }

            double avg = sum / n;

            Console.WriteLine("AVARAGE PRICE = " + avg.ToString("F2", CultureInfo.InvariantCulture));
        }
    }
}