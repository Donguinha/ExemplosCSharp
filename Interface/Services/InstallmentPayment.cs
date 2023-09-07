namespace Interface.Services
{
    internal class InstallmentPayment : IServicePayment
    {
        public double PaymentFee(double x)
        {
            return x * 0.02;
        }

        public double Interest(double amount, int month)
        {
            return amount * month * 0.01;
        }
    }
}
