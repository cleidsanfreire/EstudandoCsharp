namespace IntroDelegates.Service
{
    internal class Calculantion
    {
        public static double Sum(double n1, double n2)
        {
            return n1 + n2;
        }

        public static double Max(double n1, double n2)
        {
            return n1 > n2 ? n1 : n2;
        }

        public static double Square(double n)
        {
            return n * n;
        }
    }
}
