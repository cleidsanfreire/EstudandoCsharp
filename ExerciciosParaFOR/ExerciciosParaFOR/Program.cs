using System;
using System.Drawing;
using System.Globalization;
using System.Runtime.ConstrainedExecution;

namespace ExerciciosParaFor
{
    class Program
    {
        static void Main(string[] args)
        {
            //Exercício 01
            //Leia um valor inteiro X(1 <= X <= 1000).Em seguida mostre os ímpares de 1 até X, um valor por linha, inclusive o
            //X, se for o caso. 

            //Console.Write("Digite um valor inteiro:");
            //int x = int.Parse(Console.ReadLine());

            //for (int i = 0; i <= x; i++)
            //{
            //    if (i % 2 != 0)
            //    {
            //        Console.WriteLine(i);
            //    }
            //}

            //Exercício 02
            //Leia um valor inteiro N.Este valor será a quantidade de valores inteiros X que serão lidos em seguida. 
            //Mostre quantos destes valores X estão dentro do intervalo[10, 20] e quantos estão fora do intervalo, mostrando
            //essas informações conforme exemplo(use a palavra "in" para dentro do intervalo, e "out" para fora do intervalo). 

            //Console.Write("Digite um número: ");
            //int numeroDeVezes = int.Parse(Console.ReadLine());

            //int inNumeoroIntervalo = 0;
            //int outNumeoroIntervalo = 0;

            //for (int i = 0; i < numeroDeVezes; i++)
            //{
            //    Console.Write("Digite o proximo número: ");
            //    int numeoroDentroDoIntervalo = int.Parse(Console.ReadLine());

            //    if (numeoroDentroDoIntervalo >= 10 && numeoroDentroDoIntervalo <= 20)
            //    {
            //        inNumeoroIntervalo++;
            //    }else
            //    {
            //        outNumeoroIntervalo++;
            //    }

            //}

            //Console.WriteLine(inNumeoroIntervalo + " In");
            //Console.WriteLine(outNumeoroIntervalo + " Out");

            //Exercício 03
            //Leia 1 valor inteiro N, que representa o número de casos de teste que vem a seguir. Cada caso de teste consiste
            //de 3 valores reais, cada um deles com uma casa decimal.Apresente a média ponderada para cada um destes
            //conjuntos de 3 valores, sendo que o primeiro valor tem peso 2, o segundo valor tem peso 3 e o terceiro valor tem
            //peso 5.

            //Console.Write("Digite o numero de casos de teste: ");
            //int numeroDeCasosDeTeste = int.Parse(Console.ReadLine());

            //for (int i = 0; i < numeroDeCasosDeTeste; i++)
            //{
            //    string[] casoDeTeste = Console.ReadLine().Split(" ");
            //    double caso1 = double.Parse(casoDeTeste[0], CultureInfo.InvariantCulture);
            //    double caso2 = double.Parse(casoDeTeste[1], CultureInfo.InvariantCulture);
            //    double caso3 = double.Parse(casoDeTeste[2], CultureInfo.InvariantCulture);
            //    // Alternativa

            //    // double resultado = (caso1 * 2.0 + caso2 * 3.0 + caso3 * 5.0) / 10.0;

            //    caso1 *= 2;
            //    caso2 *= 3;
            //    caso3 *= 5;

            //    double resultado = (caso1 + caso2 + caso3) / 10;

            //    Console.WriteLine(resultado.ToString("F1", CultureInfo.InvariantCulture));
            //}

            //Exercício 04
            //Fazer um programa para ler um número N. Depois leia N pares de números e mostre a divisão do primeiro pelo
            //segundo.Se o denominador for igual a zero, mostrar a mensagem "divisao impossivel".

            //Console.Write("Digite um numero de contagem: ");
            //int numeroDeContagem = int.Parse(Console.ReadLine());

            //for (int i = 0; i < numeroDeContagem; i++)
            //{
            //    string[] paresDeNumeros = Console.ReadLine().Split(" ");
            //    double numero1 = double.Parse(paresDeNumeros[0], CultureInfo.InvariantCulture);
            //    double numero2 = double.Parse(paresDeNumeros[1], CultureInfo.InvariantCulture);


            //    if (numero2 == 0)
            //    {
            //        Console.WriteLine("Divisao impossivel");
            //    } else
            //    {
            //        double resultado = numero1 / numero2;
            //        Console.WriteLine(resultado.ToString("F1", CultureInfo.InvariantCulture));
            //    }
            //}

            //Exercício 05

            //Ler um valor N. Calcular e escrever seu respectivo fatorial. Fatorial de N = N * (N - 1) * (N - 2) * (N - 3) * ... *1.
            //Lembrando que, por definição, fatorial de 0 é 1.

            //int n = int.Parse(Console.ReadLine());

            //int fatorial = 1;

            ////Simplificando
            //for (int i = 1; i < n; i++)
            //{
            //    fatorial *= i;
            //}
            ////if (n == 0) {

            ////    fatorial = 1;
            ////}
            ////for (int i = 1; i < n; i++)
            ////{
            ////    if (n != 0)
            ////    {
            ////        fatorial *= i;
            ////    }
            ////}

            //Console.WriteLine(fatorial);

            //Exercício 06
            //Ler um número inteiro N e calcular todos os seus divisores.
            //Console.Write("Digite o numero a dividir: ");
            //int n = int.Parse(Console.ReadLine());

            //for (int i = 1; i <= n; i++)
            //{
            //    if (n % i == 0)
            //    {

            //        Console.WriteLine(i);
            //    }
            //}
            //Exercício 07
            //Fazer um programa para ler um número inteiro positivo N. O programa deve então mostrar na tela N linhas, 
            //começando de 1 até N. Para cada linha, mostrar o número da linha, depois o quadrado e o cubo do valor, conforme
            //exemplo.

            Console.Write("Digite um numero Inteiro Positivo: ");
            int numIntPos = int.Parse(Console.ReadLine());
            int quadrado = 0;
            int cubo = 0;

            for (int i = 1; i <= numIntPos; i++)
            {
                quadrado = i * i;
                cubo = i * i * i;
                Console.WriteLine($"Linhas: {i} | Quadrado: {quadrado} | Cubo: {cubo}");
            }
        }
    }
}