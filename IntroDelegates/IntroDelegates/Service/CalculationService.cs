namespace IntroDelegates.Service
{
    internal class CalculationService
    {
        public static void ShowSum(double n1, double n2)
        {
            double sum = n1 + n2;
            Console.WriteLine(sum);
        }

        public static void ShoMax(double n1, double n2)
        {
            double max = (n1 > n2) ? n1 : n2;
            Console.WriteLine(max);
        }

    }
}
