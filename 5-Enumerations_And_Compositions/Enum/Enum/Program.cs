using Enum.Entities;
using Enum.Entities.Enums;
using System;

namespace Enum
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Order ordem = new Order()
            {
                Id = 1,
                Moment = DateTime.Now,
                Status = OrderStatus.PendingPayment
            };

            Console.WriteLine(ordem);
        }
    }
}
