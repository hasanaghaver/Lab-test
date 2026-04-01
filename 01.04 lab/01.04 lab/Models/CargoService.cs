using _01._04_lab.Models.Enums;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _01._04_lab.Models
{
    class CargoService : ICargoService
    {

        private static Customer[] customers = [];
        private static Courier[] couriers = []; 
        private static CargoOrder[] Order = [];
        public void AddCostumer(Customer newCustomer)
        {
            Array.Resize(ref customers, customers.Length + 1);
            customers[customers.Length - 1] = newCustomer;
        }

        public void AddCourier(Courier newCourier)
        {
            Array.Resize(ref couriers, couriers.Length + 1);
            couriers[couriers.Length - 1] = newCourier;
        }

        public void CompleteOrder(int Id)
        {
            foreach (var order in Order)
            {
                if (order.Id == Id)
                {
                    order.UpdateStatus(OrderStatus.Delivered);
                    foreach (var courier in couriers)
                    {
                        if (courier.Id == order.CustomerId)
                        {
                            courier.IsAvailable = true;
                            break;
                        }
                    }
                    break;
                }
            }
            

        }

        public void CreateOrder(CargoOrder newOrder)
        {
            Customer exsistCustumer = null;
            foreach (var customer in customers)
            {
                if (customer.Id == newOrder.CustomerId)
                {
                    exsistCustumer = customer;
                }
            }
            if (exsistCustumer == null)
            {
                Console.WriteLine("Istifadeci tapilmadi");
            }

            Courier exsistCourier = null;
            foreach (var courier in couriers)
            {
                if (courier.Id == newOrder.CustomerId)
                {
                    exsistCourier = courier;
                }
            }
            if (exsistCourier == null)
            {
                Console.WriteLine("Kuryer tapilmadi");
            }
            if (exsistCourier.IsAvailable)
            {
                exsistCourier.IsAvailable = false;
                Array.Resize(ref Order, Order.Length + 1);
                Order[Order.Length - 1] = newOrder;
            }
            else
            {
                Console.WriteLine("Kuryer mesquldu. Basqa vaxt sifaris ver!");
            }


        }
    }
}
