using System;
using Enum_One.Entities;
using Enum_One.Entities.Enums;

namespace Enum_One
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


            string txt = OrderStatus.PedingPayment.ToString(); // Convete o tipo enúmerado em string.
            Console.WriteLine(txt);

            OrderStatus os = Enum.Parse<OrderStatus>("Delivered"); // Converte o tipo strins em tipo enúmerado.
            Console.WriteLine(os);
        }
    }
}
