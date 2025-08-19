using ExerciceFixacaoInterface.Entities;

namespace ExerciceFixacaoInterface.Service
{
    internal class ContractService
    {
        public IOnlinePaymentService _onlinePaymentService { get; set; }

        public ContractService() { }
        public ContractService(IOnlinePaymentService onlinePaymentService)
        {
            _onlinePaymentService = onlinePaymentService;
        }

        public void ProcessContract(Contract contract, int months)
        {
            double basicValue = contract.TotalValue / months;

            for (int i = 1; i <= months; i++)
            {
                DateTime date = contract.Date.AddMonths(i);
                double updateQuota = basicValue + _onlinePaymentService.Interest(basicValue, i);
                double totalQuota = updateQuota + _onlinePaymentService.PaymentFee(updateQuota);

                contract.AddInstalments(new Installment(date, totalQuota));
            }
        }
    }
}
