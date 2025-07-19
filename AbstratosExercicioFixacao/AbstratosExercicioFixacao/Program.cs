using AbstratosExercicioFixacao.Entities;
using System.Globalization;

namespace AbstratosExercicioFixacao
{
    class Program
    {
        static void Main(string[] args)
        {
            List<Person> listPerson = new List<Person>();

            Console.Write("Enter the number of tax payers: ");
            int n = int.Parse(Console.ReadLine());

            for (int i = 1; i <= n; i++)
            {
                Console.WriteLine($"Tax payer #{i} data:");
                Console.Write("Individual or company(i/c)? ");
                char ch = char.Parse(Console.ReadLine());
                Console.Write("Name: ");
                string name = Console.ReadLine();
                Console.Write("Anual income: ");
                double income = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
                
                if (ch == 'i')
                {
                    Console.Write("Health expenditures: ");
                    double gastoSaude = double.Parse(Console.ReadLine() , CultureInfo.InvariantCulture);
                    listPerson.Add(new PersonFisica(name,income,gastoSaude));
                }
                else
                {
                    Console.Write("Number of employees: ");
                    int employees = int.Parse(Console.ReadLine());
                    listPerson.Add(new PersonJuridica(name,income, employees));
                }
            }

            Console.WriteLine("\nTAXES PAID:");
            double totalTaxes = 0;

            foreach (Person p in listPerson)
            {
                Console.WriteLine(p);
                totalTaxes += p.Taxa();
            }

            Console.WriteLine($"\nTOTAL TAXES: $ {totalTaxes.ToString("F2", CultureInfo.InvariantCulture)}");
        }
    }
}