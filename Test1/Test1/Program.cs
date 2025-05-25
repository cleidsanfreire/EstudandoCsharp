using System;
using System.Globalization;

namespace Test1
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Digite Altura (utilizando o modelo 1.70) e o sexo [1 Fem / 2 Masc] na mesma linha.");
            string[] info = Console.ReadLine().Split(" ");

            double altura = double.Parse(info[0], CultureInfo.InvariantCulture);
            int sexo = int.Parse(info[1]);

            double peso;

            if (sexo == 1)
            {
                peso = (62.1 * altura) - 44.7;
                Console.WriteLine("Peso ideal Feminino:");
                Console.WriteLine(peso);
            }
            else
            {
                peso = (72.7 * altura) - 58;
                Console.WriteLine("Peso ideal Masculino:");
                Console.WriteLine(peso);
            }
        }
    }
}