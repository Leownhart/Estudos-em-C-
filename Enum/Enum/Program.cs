using Enum.Entities.Enums;
using Enum.Entities;
using System;

namespace Enum
{
    class Program
    {
        static void Main(string[] args)
        {
            Order order = new Order
            {
                Id = 1080,
                Moment = DateTime.Now,
                Status = OrderStatus.PedingPayment
            };
            Console.WriteLine(order);

            // Conversão de um tipo enumerado para string
            string txt = OrderStatus.PedingPayment.ToString();
            Console.WriteLine(txt); 

            // Conversão de um tipo string para enumerado
            OrderStatus os = Enum.Parse<OrderStatus>("Delivered");
            Console.WriteLine(os);
        }
    }
}
