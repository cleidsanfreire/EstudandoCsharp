using System;
using System.Drawing;
using System.Globalization;
using System.Runtime.ConstrainedExecution;
using static System.Net.Mime.MediaTypeNames;

namespace ExercíciosSobreEstruturaSequencial
{
    class Program
    {
        static void Main(string[] args)
        {
            //Exercício 06


            //Fazer um programa que leia três valores com ponto flutuante de dupla precisão: A, B e C.Em seguida, calcule e
            //mostre:  
            //a) a área do triângulo retângulo que tem A por base e C por altura.  
            //b) a área do círculo de raio C. (pi = 3.14159)
            //c) a área do trapézio que tem A e B por bases e C por altura.
            //d) a área do quadrado que tem lado B.  
            //e) a área do retângulo que tem lados A e B. 

            string[] valores = Console.ReadLine().Split(' ');

            double pi = 3.14159;

            double a = double.Parse(valores[0], CultureInfo.InvariantCulture);
            double b = double.Parse(valores[1], CultureInfo.InvariantCulture);
            double c = double.Parse(valores[2], CultureInfo.InvariantCulture);

            double areaTrian = (a * c) / 2 ;
            double raio = pi * (c * c);
            double trapezio = ((a + b) * c) / 2;
            double quadrado = b * b;
            double retangulo = a * b;

            Console.WriteLine($"TRIANGULO: {areaTrian.ToString("F3", CultureInfo.InvariantCulture)}");
            Console.WriteLine($"RAIO: {raio.ToString("F3", CultureInfo.InvariantCulture)}");
            Console.WriteLine($"Trapezio: {trapezio.ToString("F3", CultureInfo.InvariantCulture)}");
            Console.WriteLine($"Quadrado: {quadrado.ToString("F3", CultureInfo.InvariantCulture)}");
            Console.WriteLine($"Retangulo: {retangulo.ToString("F3", CultureInfo.InvariantCulture)}");


            //Exercício 05

            //Fazer um programa para ler o código de uma peça 1,
            //o número de peças 1, o valor unitário de cada peça 1, o código de uma peça 2,
            //o número de peças 2 e o valor unitário de cada peça 2.
            //Calcule e mostre o valor a ser pago.

            //string produtos1 = Console.ReadLine();
            //string[] p1Info = produtos1.Split(' ');
            //int codigo1 = int.Parse(p1Info[0]);
            //int numPecas1 = int.Parse(p1Info[1]);
            //double valorUnit1 = double.Parse(p1Info[2], CultureInfo.InvariantCulture);

            //string[] produtos2 = Console.ReadLine().Split(' ');
            //int codigo2 = int.Parse(produtos2[0]);
            //int numPecas2 = int.Parse(produtos2[1]);
            //double valorUnit2 = double.Parse(produtos2[2], CultureInfo.InvariantCulture);

            //double total = (valorUnit1 * numPecas1) + (valorUnit2 * numPecas2);

            //Console.WriteLine($"Valor a Pagar: R$ {total.ToString("F2", CultureInfo.InvariantCulture)}");

            //Exercício 04

            //Fazer um programa que leia o número de um funcionário, seu número de horas trabalhadas, o valor que recebe por
            //hora e calcula o salário desse funcionário.A seguir, mostre o número e o salário do funcionário, com duas casas
            //decimais.

            //int num = int.Parse(Console.ReadLine());
            //int houras = int.Parse(Console.ReadLine());
            //double valorHora = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

            //double salario = valorHora * houras;

            //Console.WriteLine($"Number =  {num}");
            //Console.WriteLine($"Salario = U$ {salario.ToString("F2", CultureInfo.InvariantCulture)}");

            //Exercício 03

            //Fazer um programa para ler quatro valores inteiros A, B, C e D.
            //A seguir, calcule e mostre a diferença do produto de A e B pelo produto de C e D
            //segundo a fórmula: DIFERENCA = (A * B - C * D).

            //int a = int.Parse(Console.ReadLine());
            //int b = int.Parse(Console.ReadLine());
            //int c = int.Parse(Console.ReadLine());
            //int d = int.Parse(Console.ReadLine());

            //int dif = a * b - c * d;

            //Console.WriteLine("DIFERENCA = " + dif);


            //Exercício 02

            //Faça um programa para ler o valor do raio de um círculo,
            //e depois mostrar o valor da área deste círculo com quatro casas decimais conforme exemplos.
            //Fórmula da área: area = π.raio2
            //Considere o valor de π = 3.14159

            //double pi = 3.14159;

            //double raio = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

            //double fA = pi * (raio * raio);

            //Console.WriteLine($"A = {fA.ToString("F4", CultureInfo.InvariantCulture)}");

            //Exercício 01 
            //Faça um programa para ler dois valores inteiros, e depois mostrar na tela a soma desses números com uma 
            //mensagem explicativa, conforme exemplos.

            //int a = int.Parse(Console.ReadLine());
            //int b = int.Parse(Console.ReadLine());

            //int s = a + b;

            //Console.WriteLine($"SOMA = {s}");
        }
    }
}