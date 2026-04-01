using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _01._04_lab.Models
{
    interface ICargoService
    {
        #region menYazan
        //static Customer[] customers = new Customer[0];
        //static Courier[] couriers = new Courier[0];
        //static CargoOrder[] cargos = new CargoOrder[0];

        //void AddCustomer(Customer newCustomer)
        //{
        //    Array.Resize(ref customers, customers.Length + 1);
        //    customers[customers.Length - 1]= newCustomer;
        //}
        //void AddCourier(Courier newCourier)
        //{
        //    Array.Resize(ref couriers,couriers.Length + 1);
        //    couriers[couriers.Length - 1]= newCourier;
        //}
        //void CreateOrder(CargoOrder newCargo)
        //{
        //    int courier = courierFind(newCargo);
        //    if (custmerFind(newCargo) && courier>0)
        //    {
        //        if (couriers[courier].IsAvailable)
        //        {
        //            Array.Resize(ref cargos, cargos.Length + 1);
        //            cargos[cargos.Length - 1] = newCargo;
        //            couriers[courier].IsAvailable = false;
        //        }
        //        else
        //        {
        //            throw new Exception("Kuriyer mesquldur");
        //        }
        //    }
        //    else
        //    {
        //        throw new Exception("Courier ve ya Custumer Id sehv daxil edilib!");
        //    }
        //}
        //private bool custmerFind(CargoOrder newCargo)
        //{
        //    foreach (var item in customers)
        //    {
        //        if (item.Id == newCargo.CustomerId)
        //        {
        //            return true;
        //        }
        //    }
        //    return false;
        //}
        //private int courierFind(CargoOrder newCargo)
        //{
        //    for (int i = 0; i < couriers.Length; i++)
        //    {
        //        if (couriers[i].Id == newCargo.CourierId)
        //        {
        //            return i;
        //        }
        //    }
        //    return -1;
        //}
        //void CompleteOrder(int id)
        //{
        //    int cargoid = -1;
        //    for (int i = 0; i < cargos.Length; i++)
        //    {
        //        if (cargos[i].Id)
        //    }
        //} 
        #endregion
        // Ikinci men yazan
        void AddCostumer(Customer newCustomer);
        void AddCourier(Courier newCourier);
        void CreateOrder(CargoOrder newOrder);
        void CompleteOrder(int Id);
    }
}
