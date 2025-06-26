using System;
using System.Globalization;

namespace ListExercicies
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("How many employees will be registered? ");
            int n = int.Parse(Console.ReadLine());

            List<Employees> listEmployess = new List<Employees>();

            for (int i = 1; i <= n; i++)
            {
                Console.WriteLine($"Emplyoee #{i}:");
                Console.Write("ID: ");
                int id = int.Parse(Console.ReadLine());
                Console.Write("Name: ");
                string name = Console.ReadLine();
                Console.Write("Salary: ");
                double salary = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

                listEmployess.Add(new Employees(id, name, salary));
            }

            Console.Write("\nEnter the employee id that will have salary increase: ");
            int idIncrease = int.Parse(Console.ReadLine());

            Employees emp = listEmployess.Find(x => x.Id == idIncrease);

            if (emp != null)
            {
                Console.Write("Enter the percentage: ");
                double percentage = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
                emp.IncreaseSalary(percentage);
            } else
            {
                Console.WriteLine("This id does not exist!");
            }

            Console.WriteLine("\nUpdated list of employees:");
            foreach (Employees employee in listEmployess)
            {
                Console.WriteLine(employee);
            }

        }
    }
}
