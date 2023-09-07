using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AulaPedido
{
    internal class Product
    {
        public string productName { get; set; }
        public double price { get; set; }

        public Product()
        {

        }

        public Product(string productName, double price)
        {
            this.productName = productName;
            this.price = price;
        }
    }
}
