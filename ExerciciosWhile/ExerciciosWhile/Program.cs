using System;
using System.Drawing;
using System.Runtime.ConstrainedExecution;
using System.Runtime.Intrinsics.X86;
using static System.Net.Mime.MediaTypeNames;

namespace ExerciciosWhile
{
    class Program
    {
        static void Main(string[] args)
        {
            // Exercício 01
            //Escreva um programa que repita a leitura de uma senha até que ela seja válida.Para cada leitura de senha
            //incorreta informada, escrever a mensagem "Senha Invalida".Quando a senha for informada corretamente deve ser
            //impressa a mensagem "Acesso Permitido" e o algoritmo encerrado.Considere que a senha correta é o valor 2002.

            //Console.Write("Digite a senha: ");
            //int senha = int.Parse(Console.ReadLine());

            //while (senha != 2002)
            //{
            //    Console.WriteLine("Senha Invalida!");
            //    Console.Write("Tente novamente: ");
            //    senha = int.Parse(Console.ReadLine());
            //}

            //Console.WriteLine("Acesso Permitido!");

            // Exercício 02 

            //Escreva um programa para ler as coordenadas (X, Y) de uma quantidade indeterminada de pontos no sistema
            //cartesiano.Para cada ponto escrever o quadrante a que ele pertence. O algoritmo será encerrado quando pelo
            //menos uma de duas coordenadas for NULA(nesta situação sem escrever mensagem alguma).

            //Console.Write("Digite as coordenadas (X, Y):");
            //string[] cord = Console.ReadLine().Split(" ");

            //int x = int.Parse(cord[0]);
            //int y = int.Parse(cord[1]);

            //while (x != 0 && y != 0)
            //{
            //    if (x > 0 && y > 0)
            //    {
            //        Console.WriteLine("primeiro");
            //    } else if (x < 0 && y > 0)
            //    {
            //        Console.WriteLine("segundo");
            //    } else if (x < 0 && y < 0)
            //    {
            //        Console.WriteLine("terceiro");
            //    }
            //    else
            //    {
            //        Console.WriteLine("quarto");
            //    }

            //    Console.Write("Digite novamente as Coordenadas (X, Y):");
            //    cord = Console.ReadLine().Split(" ");
            //    x = int.Parse(cord[0]);
            //    y = int.Parse(cord[1]);
            //}




            // Exercício 03 


            //Um Posto de combustíveis deseja determinar qual de seus produtos tem a preferência de seus clientes. Escreva
            //um algoritmo para ler o tipo de combustível abastecido(codificado da seguinte forma: 1.Álcool 2.Gasolina 3.Diesel
            //4.Fim). Caso o usuário informe um código inválido(fora da faixa de 1 a 4) deve ser solicitado um novo código(até
            //que seja válido). O programa será encerrado quando o código informado for o número 4.Deve ser escrito a
            //mensagem: "MUITO OBRIGADO" e a quantidade de clientes que abasteceram cada tipo de combustível, conforme
            //exemplo.

            Console.WriteLine("Digite o codigo abaixo desejado:");
            Console.WriteLine("1 - Álcool \n" +
                              "2 - Gasolina \n" +
                              "3 - Diesel \n" +
                              "4 - Fim");
            int codigo = int.Parse(Console.ReadLine());

            int a = 0;
            int g = 0;
            int d = 0;

            while (codigo != 4)
            {
                if (codigo == 1)
                {
                    a++;
                }
                else if (codigo == 2)
                {
                    g++;
                }
                else if (codigo == 3)
                {
                    d++;
                }
                Console.Write("Digite outro codigo ou digite 4 para sair.");
                codigo = int.Parse(Console.ReadLine());
            }

            Console.WriteLine("Muito Obrigado!");
            Console.WriteLine("Álcool: " + a +"\n" +
                              "Gasolina: " + g + "\n" +
                              "Diesel: " + d);
        }
    }
}