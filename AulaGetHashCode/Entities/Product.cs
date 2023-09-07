using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AulaGetHashCode.Entities
{
    internal class Product
    {
        public string name { get; set; }
        public double price { get; set; }

        public Product(string name, double price)
        {
            this.name = name;
            this.price = price;
        }

        public override int GetHashCode()
        {
            return name.GetHashCode() + price.GetHashCode();
        }

        public override bool Equals(object obj)
        {
            if (!(obj is Product))
            {
                return false;
                throw new ArgumentException("Is not a product");
            }

            Product product = (Product)obj;

            return name.Equals(product.name) && price.Equals(product.price);
        }

        public override string ToString()
        {
            return $"{name}, R${price}";
        }
    }
}
