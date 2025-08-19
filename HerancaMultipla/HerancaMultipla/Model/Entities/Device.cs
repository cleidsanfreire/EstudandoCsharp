using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HerancaMultipla.Model.Entities
{
    internal abstract class Device
    {
        public int SerialNumber { get; set; }
        public abstract void ProcessDoc(string document);
    }
}
