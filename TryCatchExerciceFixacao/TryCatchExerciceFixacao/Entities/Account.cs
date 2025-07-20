
using System.Globalization;
using TryCatchExerciceFixacao.Entities.Exceptions;

namespace TryCatchExerciceFixacao.Entities
{
    internal class Account
    {
        public int Number { get; set; }
        public string Holder { get; set; }
        public double Balance { get; set; }
        public double WithdrawLimit { get; set; }

        public Account() { }

        public Account(int number, string holder, double balance, double withdrawLimit)
        {
            Number = number;
            Holder = holder;
            Balance = balance;
            WithdrawLimit = withdrawLimit;
        }

        public void Deposit(double amount)
        {
            Balance += amount;
        }

        public void Withdraw(double amount) 
        {
            if (amount > WithdrawLimit)
            {
                // ERROR
                throw new RegraExceptions("Withdraw error: The amount exceeds withdraw limit");
            }
            if (amount > Balance || Balance <= 0)
            {
                // ERROR
                throw new RegraExceptions("Withdraw error: Not enough balance");
            }
           

            Balance -= amount;
            Console.WriteLine("New balance: " + Balance);
        }

        public override string ToString()
        {
            return $"Number: {Number} | Holder: {Holder} | " +
                $"Balance: {Balance.ToString("F2", CultureInfo.InvariantCulture)} | " +
                $"Withdraw Limit: {WithdrawLimit.ToString("F2", CultureInfo.InvariantCulture)}";
        }
    }
}
