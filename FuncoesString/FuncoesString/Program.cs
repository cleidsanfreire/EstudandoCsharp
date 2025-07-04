using System;

namespace FuncoesString
{
    class Program
    {
        static void Main(string[] args)
        {
            string original = "abcde FGHIJ ABC abc DEFG      ";

            string s1 = original.ToUpper();
            string s2 = original.ToLower();
            string s3 = original.Trim();
            int n1 = original.IndexOf("bc");
            int n2 = original.LastIndexOf("bc");
            string s4 = original.Substring(3);
            string s5 = original.Substring(3, 5);
            string s6 = original.Replace("a", "x");
            string s7 = original.Replace("abc", "xy");

            bool b1 = String.IsNullOrEmpty(original);
            bool b2 = String.IsNullOrWhiteSpace(original);

            Console.WriteLine($"ToUpper: -{s1}-"); // deixa toda a String em maiusculo
            Console.WriteLine($"ToLower: -{s2}-"); // Deixa toda a string em minusculo
            Console.WriteLine($"Trim: -{s3}-"); // Cortar os espaços em branco antes da string iniciar ou dps que ela acaba
            Console.WriteLine($"IndexOf('bc'): {n1}"); // Index de onde está posicionada a letra na string
            Console.WriteLine($"LastIndexOf('bc'): {n2}"); // Index de onde está posicionada a ultima letra na string
            Console.WriteLine($"Substring(3): {s4}"); // pega na string so do index escolhido pra frente
            Console.WriteLine($"Substring(3, 5): {s5}"); // pega na string so do index escolhido pra frente e a quantidade desejada
            Console.WriteLine($"Replace('a', 'x'): {s6}"); // troca um string por outro string
            Console.WriteLine($"Replace('abc', 'xy'): {s7}"); // troca um string por outro string
            Console.WriteLine($"IsNullOrEmpty: {b1}"); // verifica se a string e nula ou vazia.
            Console.WriteLine($"IsNullOrWhiteSpace: {b2}"); // verifica se a string e nula ou vazia espaços em branco sao considerados vazio.






        }
    }
}