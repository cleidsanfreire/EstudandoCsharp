using System;
using System.Globalization;

namespace Course
{
    class Program
    {
        static void Main(string[] args)
        {
            //    string frase = Console.ReadLine();
            //    string x = Console.ReadLine();
            //    string y = Console.ReadLine();
            //    string z = Console.ReadLine();

            //    //string fraseVetor = Console.ReadLine();

            //    Console.WriteLine("Voce digitou: ");
            //    Console.WriteLine(frase);
            //    Console.WriteLine(x);
            //    Console.WriteLine(y);
            //    Console.WriteLine(z);


            //    string[] vet = Console.ReadLine().Split(' ');

            //    string a0 = vet[0];
            //    string a1 = vet[1];
            //    string a2 = vet[2];

            //    Console.WriteLine($"{a0} {a1} {a2}");

            //int n1 = int.Parse(Console.ReadLine());
            //char ch = char.Parse(Console.ReadLine());
            //double n2 = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

            //string fraseVariada = Console.ReadLine();

            //string[] vetVariado = fraseVariada.Split(' ');

            //string name = vetVariado[0];
            //char sexo = char.Parse(vetVariado[1]);
            //int idade = int.Parse(vetVariado[2]);
            //double altura = double.Parse(vetVariado[3], CultureInfo.InvariantCulture);


            //Console.WriteLine("Voce Digitou:");
            ////Console.WriteLine(n1);
            ////Console.WriteLine(ch);
            ////Console.WriteLine(n2.ToString("F2", CultureInfo.InvariantCulture));

            //Console.WriteLine($"{name} {sexo} {idade} {altura.ToString("F2", CultureInfo.InvariantCulture)}");


            // Exercicios

            var culture = CultureInfo.InvariantCulture;

            Console.WriteLine("Entre com seu nome completo:");
            string namePersona = Console.ReadLine();
            Console.WriteLine("Quantos quartos tem na sua casa?");
            int quartos = int.Parse(Console.ReadLine());
            Console.WriteLine("Entre com o preço de um produto: ");
            double precoProduto = double.Parse(Console.ReadLine(), culture);
            Console.WriteLine("Entre seu ultimo nome, idade e altura (na mesma linha):");
            string[] vetInfos = Console.ReadLine().Split(' ');

            string lastName = vetInfos[0];
            int idadePersona = int.Parse(vetInfos[1]);
            double alturaPersona = double.Parse(vetInfos[2], culture);

            Console.WriteLine("Seus Dados: ");
            Console.WriteLine("Nome: " + namePersona);
            Console.WriteLine("Total quartos: " + quartos);
            Console.WriteLine("Preço do Produto: " + precoProduto.ToString("F2", culture));
            Console.WriteLine($"Dados Pessoais: Last Name: {lastName} Age: {idadePersona} Heigth: {alturaPersona.ToString("F2", culture)}");
        }
    }
}