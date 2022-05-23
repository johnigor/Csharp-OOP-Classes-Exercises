using System;
using Enumeracao.Entities;
using Enumeracao.Entities.Enums;

//Usar as colecoes criadas no projeto

namespace Enumeracao
{
    class Program
    {
        static void Main(string[] args)
        {
            Order order = new Order
            {
                Id = 1080,
                Moment = DateTime.Now,
                Status = OrderStatus.PendingPayment
            };

            Console.WriteLine(order);

            //Para converter usar ToString 
            string txt = OrderStatus.PendingPayment.ToString();

            //Converter de string para tipo enumerado
            OrderStatus os = Enum.Parse<OrderStatus>("Delivered");

            Console.WriteLine(os);
            Console.WriteLine(txt);
        }
    }
}
