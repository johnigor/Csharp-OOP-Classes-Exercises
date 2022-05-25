using System;
using System.Globalization;
using Desafio_Enum_e_Composicao.Entities;
using Desafio_Enum_e_Composicao.Entities.Enums;

namespace Desafio_Enum_e_Composicao
{
    class Program
    {
        static void Main(string[] args)
        {
            //Inserindo dados do cliente
            Console.WriteLine("Enter client data:");
            Console.Write("Name: ");
            string name = Console.ReadLine();
            Console.Write("Email: ");
            string email = Console.ReadLine();
            Console.Write("Birth date (DD/MM/YYYY): ");
            DateTime birthDate = DateTime.Parse(Console.ReadLine());
            //Instanciando dados do cliente
            Client client = new Client(name, email, birthDate);

            //Inserindo dados do pedido
            Console.WriteLine("Enter order data:");
            Console.Write("Status: ");
            OrderStatus status = Enum.Parse<OrderStatus>(Console.ReadLine());
            //Instanciando os dados do pedido
            Order order = new Order(DateTime.Now, status, client);

            Console.Write("How many items to this order? ");
            int items = int.Parse(Console.ReadLine());

            for (int i = 1; i <= items; i++)
            {
                //Inserindo dados do produto
                Console.WriteLine($"Enter #{i} item data:");
                Console.Write("Product name: ");
                string productName = Console.ReadLine();
                Console.Write("Product price: ");
                double price = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
                //Instanciando o produto
                Product product = new Product(productName, price);

                Console.Write("Quantity: ");
                int quantity = int.Parse(Console.ReadLine());

                OrderItem orderItem = new OrderItem(quantity, price, product);

                order.AddItem(orderItem);
            }

            Console.WriteLine();
            Console.WriteLine("ORDER SUMMARY:");
            Console.WriteLine(order);
        }
    }
}
