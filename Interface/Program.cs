using Interface.Entities;
using Interface.Services;
using System;
using System.Globalization;

namespace Interface
{
    class Program
    {
        static void Main(string[] args)
        {
            //Console.Write("Enter contract data\nNumber: ");
            //var number = int.Parse(Console.ReadLine());

            //Console.Write("Date (dd/mm/yyyy): ");
            //DateTime date = DateTime.Parse(Console.ReadLine());

            //Console.Write("Contract value: ");
            //var totalvalue = double.Parse(Console.ReadLine());

            //Contract contract = new Contract(number, date, totalvalue);

            //Console.Write("Enter number of installments: ");
            //var months = int.Parse(Console.ReadLine());

            //ContractInvoice contractInvoice = new ContractInvoice(new InstallmentPayment());

            //contractInvoice.ContractCalculating(contract, months);

            //Console.WriteLine("Installments: ");

            //foreach (Installment eachcontract in contract.installment)
            //{
            //    Console.WriteLine(eachcontract);
            //}
            var random = new Random();
            var repeat = 0;
            do
            {
                var randomlyInteger = random.Next();

                Console.WriteLine("product price:     " + randomlyInteger);

                var randomlyInteger2 = random.Next();

                Console.WriteLine("Credit card limit: " + randomlyInteger2);
                Console.WriteLine();

                var product = new Buying() { Value = randomlyInteger };

                var bolResult = product.ReturnStatus(randomlyInteger, randomlyInteger2);

                Console.WriteLine(bolResult);
                Console.WriteLine();

                Console.WriteLine("0 to repeat\n1 to exit");
                repeat = int.Parse(Console.ReadLine());

                Console.Clear();
            } while (repeat == 0);
        }
    }
}