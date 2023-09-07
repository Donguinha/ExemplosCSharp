using System;
using System.Collections.Generic;

namespace AulaPedido
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Name: ");
            var name = Console.ReadLine();

            Console.Write("Email: ");
            var email = Console.ReadLine();

            Console.Write("Birth date (dd/mm/yyyy): ");
            DateTime birth = DateTime.Parse(Console.ReadLine());

            Client client1 = new Client(name, email, birth);

            Console.Write("\nEnter order data\nStatus: ");
            OrderStatus orderStatus = Enum.Parse<OrderStatus>(Console.ReadLine());

            Order order1 = new Order(DateTime.Now, orderStatus, client1);

            Console.WriteLine("How many items to this order? ");
            var itens = int.Parse(Console.ReadLine());

            for (int i = 0; i < itens; i++)
            {
                Console.WriteLine("Enter #{0} item data", (i + 1));
                Console.Write("Product name: ");
                var produto = Console.ReadLine();

                Console.Write("Price: ");
                var price = double.Parse(Console.ReadLine());

                Product product = new Product(produto, price);

                Console.Write("Quantity: ");
                var quantity = int.Parse(Console.ReadLine());

                OrderItem orderItem = new OrderItem(product, price, quantity);

                order1.AddItem(orderItem);
            }

            Console.WriteLine();
            Console.WriteLine(order1);
        }
    }
}