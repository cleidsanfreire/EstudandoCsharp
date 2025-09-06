using IntroDelegates.Service;

namespace IntroDelegates
{
    class Program
    {
        delegate double binaryCalculationNumbers(double x, double y);
        delegate void binaryCalculationNumbersServices(double x, double y);
        static void Main(string[] args)
        {
            double a = 12;
            double b = 30;

            binaryCalculationNumbers op = Calculantion.Sum;
            double result = op(a, b);
            Console.WriteLine(result);
            Console.WriteLine(Calculantion.Max(a,b));
            Console.WriteLine(Calculantion.Square(a));

            Console.WriteLine("-----Multicast delegates-----");

            binaryCalculationNumbersServices opService = CalculationService.ShowSum;
            opService += CalculationService.ShoMax;

            opService(a,b);
        }
    }
}