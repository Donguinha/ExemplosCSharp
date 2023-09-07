namespace Interface.Services
{
    interface IServicePayment
    {
        public double PaymentFee(double x);

        public double Interest(double amount, int month);
    }
}
