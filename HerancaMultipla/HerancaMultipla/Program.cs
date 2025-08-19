using HerancaMultipla.Model.Entities;

namespace HerancaMultipla
{
    class Program
    {
        static void Main(string[] args)
        {
            Scanner s = new Scanner() { SerialNumber = 1080 };
            s.ProcessDoc("My Letters");
            Console.WriteLine(s.Scan());

            Printer p = new Printer() { SerialNumber = 2525 };
            p.ProcessDoc("My Printers");
            p.Print("Stay with me");
        
            ComboDevices cb = new ComboDevices() { SerialNumber = 1524};
            cb.ProcessDoc("My dissertation");
            cb.Print("Staaaaaaaaaaaaaaay");
            Console.WriteLine(cb.Scan());
        }
    }
}