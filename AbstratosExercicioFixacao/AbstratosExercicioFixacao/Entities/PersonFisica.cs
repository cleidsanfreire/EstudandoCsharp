using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AbstratosExercicioFixacao.Entities
{
    internal class PersonFisica : Person
    {
        public double GastosSaude { get; set; }

        public PersonFisica(string name, double rendaAnual, double gastosSaude) : base(name, rendaAnual)
        {
            GastosSaude = gastosSaude;
        }

        public override double Taxa()
        {
            if (RendaAnual < 20000.00)
            {
                //pessoas cuja renda foi abaixo de 20000.00 pagam 15% de imposto
                return (RendaAnual * 0.15) - (GastosSaude * 0.50);
            }
            else
            {
                // Pessoas com renda de 20000.00 em diante pagam 25 % de imposto.
                return (RendaAnual * 0.25) - (GastosSaude * 0.50);
            }
        }
    }
}
