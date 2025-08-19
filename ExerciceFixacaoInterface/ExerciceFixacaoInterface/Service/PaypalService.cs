namespace ExerciceFixacaoInterface.Service
{
    internal class PaypalService : IOnlinePaymentService
    {
        public const double MontlyInterest = 0.01;
        public const double FeePayment = 0.02;
        public double Interest(double amount, int months)
        { 
            return amount * MontlyInterest * months;
        }

        public double PaymentFee(double amount)
        {
            return amount * FeePayment;
        }
    }
}
