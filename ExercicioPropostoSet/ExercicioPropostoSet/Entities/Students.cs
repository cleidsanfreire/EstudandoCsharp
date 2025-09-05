using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExercicioPropostoSet.Entities
{
    internal class Students
    {
        public int CodeRegister { get; set; }

        public Students(int codeRegister)
        {
            CodeRegister = codeRegister;
        }

        public override int GetHashCode()
        {
            return CodeRegister.GetHashCode();
        }

        public override bool Equals(object? obj)
        {
            if (!(obj is Students)) return false;

            Students other = obj as Students;

            return CodeRegister.Equals(other.CodeRegister);
        }
    }

}
