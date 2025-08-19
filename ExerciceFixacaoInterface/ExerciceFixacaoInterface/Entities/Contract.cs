namespace ExerciceFixacaoInterface.Entities
{
    internal class Contract
    {
        public int Number { get; set; }
        public DateTime Date { get; set; }
        public double TotalValue { get; set; }

        public List<Installment> installments { get; set; }

        public Contract() { }

        public Contract(int number, DateTime date, double totalValue)
        {
            Number = number;
            Date = date;
            TotalValue = totalValue;
            installments = new List<Installment>();
        }

        public void AddInstalments(Installment iinstallment)
        {
            installments.Add(iinstallment);
        }
    }
}
