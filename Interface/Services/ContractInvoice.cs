using Interface.Entities;

namespace Interface.Services
{
    internal class ContractInvoice
    {
        private IServicePayment servicePayment;

        public ContractInvoice(IServicePayment servicePayment)
        {
            this.servicePayment = servicePayment;
        }

        public void ContractCalculating(Contract contract, int months)
        {
            var eachinstall = contract.totalValue / months;
            

            for (int i = 1; i <= months; i++)
            {
                var x = eachinstall + servicePayment.Interest(eachinstall, i);
                var y = x + servicePayment.PaymentFee(x);

                DateTime date = contract.date.AddMonths(i);

                contract.AddInstallment(new Installment(date, y));
            }
        }
    }
}
