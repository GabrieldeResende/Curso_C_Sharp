using Enumerates.entities;
using Enumerates.entities.enums;
using System;

namespace Course {
    class program {
        static void Main(string[] args) {
            Order order = new Order {
                Id = 1080,
                Moment = DateTime.Now,
                Status = OrderStatus.PendingPayment
            };

            Console.WriteLine(order);
        }
    }
}