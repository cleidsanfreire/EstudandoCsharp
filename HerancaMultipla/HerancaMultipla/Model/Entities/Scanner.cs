using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HerancaMultipla.Model.Entities
{
    internal class Scanner : Device, IScanner
    {

        public override void ProcessDoc(string document)
        {
            Console.WriteLine("Scanner Processing " + document);
        }

        public string Scan()
        {
            return "Scanner Scan result";
        }
    }
}
