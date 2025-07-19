using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AbstratosExercicioFixacao.Entities
{
    internal abstract class Person
    {

        public string Name { get; set; }
        public double RendaAnual { get; set; }

        protected Person(string name, double rendaAnual)
        {
            Name = name;
            RendaAnual = rendaAnual;
        }

        public abstract double Taxa();

        public override string ToString()
        {
            return $"{Name}: $ {Taxa().ToString("F2", CultureInfo.InvariantCulture)}";
        }
    }
}
