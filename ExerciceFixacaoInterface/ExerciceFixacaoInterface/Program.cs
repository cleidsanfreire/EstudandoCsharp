using ExerciceFixacaoInterface.Entities;
using ExerciceFixacaoInterface.Service;
using System.Globalization;

namespace ExerciceFixacaoInterface
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter contract data");
            Console.Write("Number: ");
            int number = int.Parse(Console.ReadLine());
            Console.Write("Date (dd/MM/yyyy): ");
            DateTime date = DateTime.ParseExact(Console.ReadLine(), "dd/MM/yyyy", CultureInfo.InvariantCulture);
            Console.Write("Contract value: ");
            double value = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
            Console.Write("Enter number of installments: ");
            int months = int.Parse(Console.ReadLine());

            Contract myContract = new Contract(number, date, value);

            ContractService contract = new ContractService(new PaypalService());

            contract.ProcessContract(myContract, months);

            Console.WriteLine("Installments:");

            foreach (Installment inst in myContract.installments)
            {
                Console.WriteLine(inst);
            }
        }
    }
}