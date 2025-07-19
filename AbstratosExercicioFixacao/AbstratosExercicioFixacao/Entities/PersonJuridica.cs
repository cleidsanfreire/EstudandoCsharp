using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AbstratosExercicioFixacao.Entities
{
    internal class PersonJuridica : Person
    {
        public int NumberOfFuncionarios { get; set; }

        public PersonJuridica(string name, double rendaAnual, int numberOfFuncionarios) : base(name, rendaAnual)
        {
            NumberOfFuncionarios = numberOfFuncionarios;
        }

        public override double Taxa()
        {
            //pessoas jurídicas pagam 16% de imposto.
            if (NumberOfFuncionarios <= 10)
            {
                return RendaAnual * 0.16;
;
            }
            //Porém, se a empresa possuir mais de 10 funcionários, ela paga 14 % de imposto.
            else
            {
                return RendaAnual * 0.14;
;
            }
                
        }
    }
}
