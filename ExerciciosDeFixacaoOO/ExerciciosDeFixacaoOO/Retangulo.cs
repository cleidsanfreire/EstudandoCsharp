using ExerciciosDeFixacao;
using System;
using System.Collections.Generic;
using System.Drawing;
using System.Globalization;
using System.Linq;
using System.Runtime.ConstrainedExecution;
using System.Text;
using System.Threading.Tasks;

namespace ExerciciosDeFixacaoOO
{
    internal class Retangulo
    {
        //EXERCÍCIO 01: 
        //Fazer um programa para ler os valores da largura e altura de um retângulo.Em
        //seguida, mostrar na tela o valor de sua área, perímetro e diagonal.Usar uma classe
        //como mostrado no projeto ao lado.

        public double Largura;
        public double Altura;

        public double Area()
        {
            return Largura * Altura;
        }

        public double Perimetro()
        {
            return (Largura * 2) + (Altura * 2);
        }

        public double Diagonal()
        {
            return Math.Sqrt((Largura * Largura) + (Altura * Altura));
        }

        public override string ToString()
        {
            return $"AREA = {Area().ToString("F2", CultureInfo.InvariantCulture)}" +
                   $"\nPERIMETRO = {Perimetro().ToString("F2", CultureInfo.InvariantCulture)}" +
                   $"\nDIAGONAL = {Diagonal().ToString("F2", CultureInfo.InvariantCulture)}";
        }
    }
}
