using ExercicioFixacaoLambda.Entities;
using System.Globalization;

namespace ExercicioFixacaoLambda
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Enter full file path: ");
            string path = Console.ReadLine();

            Console.Write("Enter salary: ");
            double salaryBase = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

            List<Employee> listEmp = new List<Employee>();

            try
            {
                using (StreamReader sr = File.OpenText(path))
                {
                    while (!sr.EndOfStream)
                    {
                        string[] fields = sr.ReadLine().Split(',');
                        string name = fields[0];
                        string email = fields[1];
                        double salary = double.Parse(fields[2], CultureInfo.InvariantCulture);
                        listEmp.Add(new Employee(name, email, salary));
                    }
                }

                var alfEmail = listEmp.Where(p => p.Salary > salaryBase).OrderBy(p => p.Name).Select(p => p.Email);

                Console.WriteLine($"Email of people whose salary is more than {salaryBase.ToString("F2",CultureInfo.InvariantCulture)}:");

                foreach (string emp in alfEmail)
                {
                    Console.WriteLine(emp);
                }

                var sumStart = listEmp.Where(p => p.Name[0] == 'M').Sum(p => p.Salary);

                Console.WriteLine("Sum of salary of people whose name starts with 'M': " + sumStart.ToString("F2", CultureInfo.InvariantCulture));
            }
            catch (IOException e)
            {
                Console.WriteLine(e.Message);
            }
        }
    }
}