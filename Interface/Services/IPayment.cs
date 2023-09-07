using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Interface.Services
{
    public interface IPayment
    {
        public double Value { get; set; }
        public bool IsCompleted { get; set; }

        public bool ReturnStatus(double value, double price);
    }
}
