using ExerciciosDeFixacao;
using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Runtime.ConstrainedExecution;
using System.Text;
using System.Threading.Tasks;

namespace ExerciciosDeFixacaoOO
{
    internal class Funcionario
    {
        //
        //Fazer um programa para ler os dados de um funcionário(nome,salário bruto e imposto).
        //Em seguida, mostrar os dados do funcionário(nome e salário líquido).
        //Em seguida, aumentar o salário do funcionário com base em uma porcentagem dada
        //(somente o salário bruto é afetado pela porcentagem) e mostrar novamente os dados do funcionário.
        //Use a classe projetada abaixo.

        public string Nome;
        public double SalarioBruto;
        public double Imposto;

        public double SalarioLiquido()
        {
            return SalarioBruto - Imposto;
        }

        public void AumentarSalario(double porcentagem)
        {
            SalarioBruto += (SalarioBruto * porcentagem) / 100.00;
            Console.WriteLine("Dados Atualizados: " + ToString());
        }

        public override string ToString()
        {
            return $"{Nome}, $ {SalarioLiquido().ToString("F2", CultureInfo.InvariantCulture)}";
        }
    }
}
