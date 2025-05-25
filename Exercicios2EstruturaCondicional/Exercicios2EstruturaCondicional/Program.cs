using System;
using System.Collections.Generic;
using System.Drawing;
using System.Globalization;
using System.Net;
using System.Reflection.Emit;
using System.Runtime.ConstrainedExecution;
using System.Runtime.Intrinsics.Arm;
using System.Runtime.Intrinsics.X86;
using static System.Net.Mime.MediaTypeNames;
using static System.Runtime.InteropServices.JavaScript.JSType;

namespace Exercicios2EstruturaCondicional
{
    class Program
    {
        static void Main(string[] args)
        {
            // Exercício 06

            //Em um país imaginário denominado Lisarb, todos os habitantes ficam felizes em pagar seus impostos, pois sabem
            //que nele não existem políticos corruptos e os recursos arrecadados são utilizados em benefício da população, sem
            //qualquer desvio.A moeda deste país é o Rombus, cujo símbolo é o R$. 

            //Leia um valor com duas casas decimais, equivalente ao salário de uma pessoa de Lisarb. Em seguida, calcule e
            //mostre o valor que esta pessoa deve pagar de Imposto de Renda, segundo a tabela abaixo. 




            //Lembre que, se o salário for R$ 3002.00, a taxa que incide é de 8 % apenas sobre R$ 1000.00, pois a faixa de
            //salário que fica de R$ 0.00 até R$ 2000.00 é isenta de Imposto de Renda.No exemplo fornecido(abaixo), a taxa é
            //de 8 % sobre R$ 1000.00 + 18 % sobre R$ 2.00, o que resulta em R$ 80.36 no total.O valor deve ser impresso com
            //duas casas decimais.
           
            double salario = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

            double imposto = 0.0;
            if (salario <= 2000.00)
            {
                // Isento
                Console.WriteLine("Isento");
            }
            else if (salario <= 3000.00)
            {
                // 8%
                imposto = salario - 2000;
                imposto *= 0.08;

                Console.WriteLine(imposto);
            }
            else if (salario <= 4500.00)
            {

                // 18%
                imposto = (salario - 3000) * 0.18 + 1000 * 0.08;
                Console.WriteLine(imposto);

            }
            else
            {
                // 28%

                imposto = (salario - 4500) * 0.28 + 1000 * 0.08 + 1500 * 0.18;
                Console.WriteLine(imposto);
            }


            // Exercício 06
            //Leia 2 valores com uma casa decimal(x e y), que devem representar as coordenadas
            //de um ponto em um plano. A seguir, determine qual o quadrante ao qual pertence o
            //ponto, ou se está sobre um dos eixos cartesianos ou na origem(x = y = 0). 

                //Se o ponto estiver na origem, escreva a mensagem “Origem”. 

                //Se o ponto estiver sobre um dos eixos escreva “Eixo X” ou “Eixo Y”, conforme for a
                //situação.
                //string[] valores = Console.ReadLine().Split(" ");
                //double x = double.Parse(valores[0], CultureInfo.InvariantCulture);
                //double y = double.Parse((valores[1]), CultureInfo.InvariantCulture);



                //if (y > 0 && x > 0)
                //{
                //    Console.WriteLine("Q1");
                //}
                //else if (x == 0.0)
                //{
                //    Console.WriteLine("Eixo X");
                //}
                //else if (y == 0.0)
                //{
                //    Console.WriteLine("Eixo Y");
                //}
                //else if (y > 0 && x < 0)
                //{
                //    Console.WriteLine("Q2");
                //}
                //else if (y < 0 && x < 0)
                //{
                //    Console.WriteLine("Q3");
                //}
                //else if (y < 0 && x > 0)
                //{
                //    Console.WriteLine("Q4");
                //}
                //else
                //{
                //    Console.WriteLine("Origem");
                //}


                // Exercício 06
                //Você deve fazer um programa que leia um valor qualquer e apresente uma mensagem dizendo em qual dos
                //seguintes intervalos([0, 25], (25,50], (50, 75], (75, 100]) este valor se encontra. Obviamente se o valor não estiver em
                //nenhum destes intervalos, deverá ser impressa a mensagem “Fora de intervalo”

                //double valor = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

                //if (valor < 0.0|| valor >= 100.01)
                //{
                //    Console.WriteLine("Fora de intervalo");
                //}
                //else if (valor <= 25.0)
                //{
                //    Console.WriteLine("Intervalo [0,50]");
                //}
                //else if (valor <= 50.0)
                //{
                //    Console.WriteLine("Intervalo [25, 50]"); 
                //}
                //else if (valor <= 75.0)
                //{
                //    Console.WriteLine("Intervalo [50,75]");
                //}
                //else
                //{
                //    Console.WriteLine("Intervalo [75,100]");
                //}

                // Exercício 05
                //Com base na tabela abaixo, escreva um programa que leia o código de um item e a quantidade deste item. A 
                //seguir, calcule e mostre o valor da conta a pagar.

                //Console.WriteLine("|---------||-----------------||---------|");
                //Console.WriteLine("| CODIGO  ||  ESPECIFICAÇÃO  ||  PREÇO  |");
                //Console.WriteLine("|---------||-----------------||---------|");
                //Console.WriteLine("| 1       || Cachorro Quente || R$ 4.00 |");
                //Console.WriteLine("| 2       ||    X-Salada     || R$ 4.50 |");
                //Console.WriteLine("| 3       ||     X-Bacon     || R$ 5.00 |");
                //Console.WriteLine("| 4       || Torrada Simples || R$ 2.00 |");
                //Console.WriteLine("| 5       ||   Refrigerante  || R$ 1.50 |");
                //Console.WriteLine("|---------||-----------------||---------|");

                //string[] num = Console.ReadLine().Split(" ");

                //int codigo = int.Parse(num[0]);
                //int quant = int.Parse(num[1]);

                //double preco = 0;
                //if (codigo == 1)
                //{
                //    preco = 4.00 * quant;
                //}
                //else if (codigo == 2)
                //{
                //    preco = 4.50 * quant;
                //}
                //else if (codigo == 3)
                //{
                //    preco = 5.00 * quant;
                //}
                //else if (codigo == 4)
                //{
                //    preco = 2.00 * quant;
                //}
                //else if (codigo == 5)
                //{
                //    preco = 1.50 * quant;
                //}
                //else
                //{
                //    Console.WriteLine("Codigo ou Quantidade errada.");
                //}

                //Console.WriteLine($"Total: R$ {preco.ToString("F2", CultureInfo.InvariantCulture)}");

                // Exercício 04
                //Leia a hora inicial e a hora final de um jogo. A seguir calcule a duração do jogo, sabendo que o mesmo pode 
                //começar em um dia e terminar em outro, tendo uma duração mínima de 1 hora e máxima de 24 horas.

                //string[] horas = Console.ReadLine().Split(" ");

                //int horaInicial = int.Parse(horas[0]); // 16
                //int horaFinal = int.Parse(horas[1]); // 2

                //int duracao;
                //if (horaInicial < horaFinal)
                //{
                //    duracao = horaFinal - horaInicial;
                //}
                //else
                //{
                //    duracao = 24 - horaInicial + horaFinal;
                //}

                //Console.WriteLine($"O JOGO DUROU {duracao} HORA(S)");

                // Exercício 03
                //Leia 2 valores inteiros (A e B). Após, o programa deve mostrar uma mensagem "Sao Multiplos" ou "Nao sao 
                //Multiplos", indicando se os valores lidos são múltiplos entre si. Atenção: os números devem poder ser digitados em 
                //ordem crescente ou decrescente. 
                //string[] nums = Console.ReadLine().Split(" ");
                //int a = int.Parse(nums[0]);
                //int b = int.Parse(nums[1]);

                //if (a % b == 0 || b % a == 0)
                //{
                //    Console.WriteLine("Sao Multiplos");
                //}
                //else
                //{
                //    Console.WriteLine("Nao sao Multiplos");
                //}
                //int numInt = int.Parse(Console.ReadLine());
                // Exercício 02
                //  Fazer um programa para ler um número inteiro e dizer se este número é par ou ímpar.
                //if (numInt % 2 == 0 )
                //{
                //    Console.WriteLine("PAR!");
                //}
                //else
                //{
                //    Console.WriteLine("IMPAR!");
                //}
                // Exercício 01 

                // Fazer um programa para ler um número inteiro, e depois dizer se este número é negativo ou não.

                //if (numInt >= 0)
                //{
                //    Console.WriteLine("NAO NEGATIVO");
                //}
                //else
                //{
                //    Console.WriteLine("NEGATIVO");

                //}
        }
    }
}