using System;
using Enumeradores.Entities;
using Enumeradores.Entities.Enums;

namespace Enumeradores
{
    class Program
    {
        static void Main(string[] args)
        {

            Order order = new Order()
            {
                Id = 1234,
                Moment = DateTime.Now,
                Status = OrderStatus.Shipped
            };

            Console.WriteLine(order);

            string txt = OrderStatus.PendingPayment.ToString();
            Console.WriteLine(txt);


            OrderStatus os = Enum.Parse<OrderStatus>("Delivedred");
            Console.WriteLine(os);

                

        }
    }
}
