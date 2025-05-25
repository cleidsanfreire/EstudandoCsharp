using System.Diagnostics;

namespace MyProject;

class Program
{
    static void Main(string[] args)
    {
        //sbyte sb_sbyte = 120;
        //Console.WriteLine(sb_sbyte);

        //byte b_byte = 255; // 0 a 255 (nao aceita numeros negativos)

        //b_byte++;

        //Console.WriteLine(b_byte + " Antes");

        //if (b_byte > 0 && b_byte <= 255)
        //{
        //    Console.WriteLine(b_byte);

        //} else
        //{
        //    b_byte = 255;
        //    Console.WriteLine(b_byte + " Redondo");
        //}


        // Numeros Inteiros.

        //byte n1 = 126;
        //int n2 = 2147483647;
        //int n3 = -2147483648;
        //long n4 = 2147483648L;

        //Console.WriteLine(n1);
        //Console.WriteLine(n2);
        //Console.WriteLine(n3);
        //Console.WriteLine(n4);

        //// Numeros quebrados
        //float n5 = 4.5f;
        //double n6 = 4.5;

        //Console.WriteLine(n5);
        //Console.WriteLine(n6);

        //// Valor Verdade ou Falso
        //bool b_completo = false;

        //Console.WriteLine(b_completo);

        //// Caracter
        //char genero = 'F';
        //char letra = '\u0041';

        //Console.WriteLine(genero);
        //Console.WriteLine(letra);

        //// Texto (CADEIA DE CARACTERS)

        //string nome = "Maria Green";

        //// Objects

        //object obj1 = "Alesk";
        //object obj2 = 1525;

        //// Minimos e maximos
        // int n1 = int.MinValue;
        // int n2 = int.MaxValue;
        //Console.WriteLine(n1);
        //Console.WriteLine(n2);

        //decimal n3 = decimal.MaxValue;
        //Console.WriteLine(n3);

        //long n4 = long.MaxValue;
        //Console.WriteLine(n4);

        Console.WriteLine("Digite um numero");
        string num1 = Console.ReadLine();
        Console.WriteLine("Escolha entre [+] [-] [*] [/]");
        string op = Console.ReadLine();
        Console.WriteLine("Escolha um segundo numero");
        string num2 = Console.ReadLine();

        double numConvert1 = int.Parse(num1);
        double numConvert2 = int.Parse(num2);

        double result = 0;

        switch (op)
        {
            case "+":
                result = numConvert1 + numConvert2;
                break;
            case "-":
                result = numConvert1 - numConvert2;
                break;
            case "*":
                result = numConvert1 * numConvert2;
                break;
            case "/":
                result = numConvert1 / numConvert2;
                break;
            default:
                Console.WriteLine("Numero ou Opção incorreto.");
                break;
        }

        Console.WriteLine("Resutlado: " + result);
    }
}