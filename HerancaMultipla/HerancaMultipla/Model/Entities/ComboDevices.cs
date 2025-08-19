using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HerancaMultipla.Model.Entities
{
    internal class ComboDevices : Device, IScanner, IPrinter
    {
        public void Print(string document)
        {
            Console.WriteLine("ComboDevice Printer Processing " + document);
        }

        public override void ProcessDoc(string document)
        {
            Console.WriteLine("ComboDevice Processing " + document);
        }

        public string Scan()
        {
            return "ComboDevice Scan result";
        }
    }
}
