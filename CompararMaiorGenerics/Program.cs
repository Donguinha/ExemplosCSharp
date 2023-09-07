using CompararMaiorGenerics.Services;
using CompararMaiorGenerics.Entities;
using System;
using System.Globalization;

namespace CompararMaiorGenerics
{
    class Program
    {
        static void Main(string[] args)
        {
            List<Product> products = new List<Product>();

            Console.Write("How many product will be add: ");
            int n = int.Parse(Console.ReadLine());

            for (int i = 0; i < n; i++)
            {
                string[] details = Console.ReadLine().Split(',');

                double price = double.Parse(details[1], CultureInfo.InvariantCulture);

                products.Add(new Product(details[0], price));
            }

            CalculationService calculationService = new CalculationService();

            Product max = calculationService.Max(products);

            Console.WriteLine("Highest: " + max);

        }
    }
}