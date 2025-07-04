using System.Globalization;

namespace DateTimes
{
    class Program
    {
        static void Main(string[] args)
        {
            //DateTime d1 = DateTime.Now; // Data atual do sistema

            //Console.WriteLine(d1);
            //Console.WriteLine(d1.Ticks);

            //DateTime d2 = new DateTime(2025, 11, 25);
            //DateTime d3 = new DateTime(2025, 11, 25, 20,45,42);
            //DateTime d4 = new DateTime(2025, 11, 25, 20,45,42, 500);
            //DateTime d5 = DateTime.Now; // Hora atual
            //DateTime d6 = DateTime.Today; // data de hj com horario zerado
            //DateTime d7 = DateTime.UtcNow; // horario de agora no Greenwich (horario universal)

            //Console.WriteLine(d2);
            //Console.WriteLine(d3);
            //Console.WriteLine(d4);
            //Console.WriteLine("DateTime.Now: " + d5);
            //Console.WriteLine("DateTime.Today: " + d6);
            //Console.WriteLine("DateTime.UtcNow: " + d7);

            //DateTime d8 = DateTime.Parse("2000-08-15");
            //DateTime d9 = DateTime.Parse("2000-08-15 13:05:58");
            //DateTime d10 = DateTime.Parse("07/03/2000");
            //DateTime d11 = DateTime.Parse("07/03/2000 13:05:58");

            //Console.WriteLine("DateTime.Parse: " + d8);
            //Console.WriteLine("DateTime.Parse: " + d9);
            //Console.WriteLine("DateTime.Parse: " + d10);
            //Console.WriteLine("DateTime.Parse: " + d11);

            DateTime d12 = DateTime.ParseExact("2000-08-15", "yyyy-MM-dd", CultureInfo.InvariantCulture);
            DateTime d13 = DateTime.ParseExact("07/03/2000 13:25:45", "dd/MM/yyyy HH:mm:ss", CultureInfo.InvariantCulture);
            Console.WriteLine(d12);
            Console.WriteLine(d13);
        }
    }
}