using ExercicioPropostoSet.Entities;

namespace ExercicioPropostoSet
{
    class Program
    {
        static void Main(string[] args)
        {
            HashSet<Students> sA = new HashSet<Students>();
            HashSet<Students> sB = new HashSet<Students>();
            HashSet<Students> sC = new HashSet<Students>();

            Console.Write("How many students for course A? ");
            int cA = int.Parse(Console.ReadLine());

            for (int i = 0; i < cA; i++)
            {
                int student = int.Parse(Console.ReadLine());
                sA.Add(new Students(student));
            }

            Console.Write("How many students for course B? ");
            int cB = int.Parse(Console.ReadLine());

            for (int i = 0; i < cB; i++)
            {
                int student = int.Parse(Console.ReadLine());
                sB.Add(new Students(student));
            }
            Console.Write("How many students for course C? ");
            int cC = int.Parse(Console.ReadLine());

            for (int i = 0; i < cC; i++)
            {
                int student = int.Parse(Console.ReadLine());
                sC.Add(new Students(student));
            }

            HashSet<Students> sT = new HashSet<Students>(sA);
            sT.UnionWith(sB);
            sT.UnionWith(sC);

            Console.WriteLine("Total students: " + sT.Count);
        }
    }
}