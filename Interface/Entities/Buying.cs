using Interface.Services;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Interface.Entities
{
    public class Buying : IPayment
    {
        public double Value { get; set; }
        public bool IsCompleted { get; set; }

        public bool ReturnStatus(double value, double price)
        {
            if(price > 0 && value > 0 && value >= price)
            {
                var result = value - price;
                Console.WriteLine("product bought, you still have " + result);
                return IsCompleted = true;
            }

            Console.WriteLine("It's does not possible buy the product");
            return IsCompleted = false;
        }
    }
}
