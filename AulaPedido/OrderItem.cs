using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AulaPedido
{
    internal class OrderItem
    {
        public int quantity { get; set; }
        public double price { get; set; }
        public Product Product { get; set; }

        public OrderItem(Product product, double price, int quantity)
        {
            Product = product;
            this.price = price;
            this.quantity = quantity;
        }

        public double SubTotal()
        {
            return quantity * price;
        }

        public override string ToString()
        {
            return $"{Product.productName}, ${price}, Quantity: {quantity}, Subtotal: ${price * quantity}";
        }
    }
}
