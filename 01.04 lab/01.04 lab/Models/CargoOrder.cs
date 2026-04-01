using _01._04_lab.Models.Enums;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _01._04_lab.Models
{
    class CargoOrder
    {
        private static int count;
        public int Id { get; set; }
        public int CustomerId { get; set; }
        public int CourierId { get; set; }
        public double TotalAmount { get; set; }
        public OrderStatus orderStatus;
        private DateTime CreatedAt { get; set; }

        public CargoOrder()
        {
            count++;
            Id = count;
            CreatedAt = DateTime.Now;
            orderStatus = OrderStatus.Created;
        }
        public void UpdateStatus(OrderStatus status)
        {
            if (status ==OrderStatus.Cancelled)
            {
                Console.WriteLine("Sizin sifaris legv olunub deye deyise bilmir.");
            }else if (status ==OrderStatus.Delivered)
            {
                Console.WriteLine("Sifaris catdirilib deye deyisdirile bilmez.");
            }
            else
            {
                orderStatus = status;
                Console.WriteLine("Status yenilendi!");
            }
        }
    }
}
