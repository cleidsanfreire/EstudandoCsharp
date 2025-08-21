using GenericsExercices.Services;

namespace GenericsExercices
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            PrintService<int> p = new PrintService<int>();

            for (int i = 0; i < n; i++)
            {
                int value = int.Parse(Console.ReadLine());

                p.AddValue(value);
            }

            p.Print();

            Console.WriteLine("First: " + p.First());

        }
    }
}