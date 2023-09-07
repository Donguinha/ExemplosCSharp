using Microsoft.VisualBasic;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.Text;
using System.Threading.Tasks;

namespace AulaPedido
{
    internal class Order
    {
        public DateTime Date { get; set; }
        public OrderStatus OrderStatus { get; set; }
        public Client Client { get; set; }
        public List<OrderItem> Items { get; set; } = new List<OrderItem>();

        public Order(DateTime date, OrderStatus orderStatus, Client client)
        {
            Date = date;
            OrderStatus = orderStatus;
            Client = client;
        }

        public void AddItem(OrderItem item)
        {
            Items.Add(item);
        }

        public void RemoveItem(OrderItem item)
        {
            Items.Remove(item);
        }

        public double Total()
        {
            var sum = 0.0;
            foreach (OrderItem eachItem in Items)
            {
                sum += eachItem.SubTotal();
            }
            return sum;
        }

        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();
            sb.AppendLine("ORDER SUMMARY");
            sb.AppendLine($"Order Moment: {Date.ToString("dd/MM/yyyy HH:mm:ss")}");
            sb.AppendLine("Order Status: " + OrderStatus);
            sb.AppendLine($"Client: {Client}");
            sb.AppendLine($"Order itens:");
            foreach (OrderItem eachItem in Items)
            {
                sb.AppendLine(eachItem.ToString());
            }
            sb.AppendLine("Total price: $" + Total());

            return sb.ToString();
        }
    }
}
