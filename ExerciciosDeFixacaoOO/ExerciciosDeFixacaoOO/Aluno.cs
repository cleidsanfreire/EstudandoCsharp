using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExerciciosDeFixacaoOO
{
    internal class Aluno
    {
        //Fazer um programa para ler o nome de um aluno e as três notas que ele obteve nos três trimestres do ano 
        //(primeiro trimestre vale 30 e o segundo e terceiro valem 35 cada). Ao final, mostrar qual a nota final do aluno no
        //ano.Dizer também se o aluno está APROVADO ou REPROVADO e, em caso negativo, quantos pontos faltam
        //para o aluno obter o mínimo para ser aprovado(que é 60 pontos). Você deve criar uma classe Aluno para resolver
        //este problema. 

        public string Nome;
        public double N1, N2, N3;
        public double CalculaNotaFinal()
        {
            return N1 + N2 + N3;
        }

        public bool Aprovado()
        {
            if (CalculaNotaFinal() >= 60)
            {
                return true;
            }else
            {
                return false;
            }
        }

        public double NotaRestante()
        {
            if (Aprovado())
            {
                return 0.0;
            }
            else
            {
                return 60.0 - CalculaNotaFinal();
            }
        }

        public override string ToString()
        {
            return $"NOTA FINAL = {CalculaNotaFinal().ToString("F2", CultureInfo.InvariantCulture)}";
        }




    }
}
