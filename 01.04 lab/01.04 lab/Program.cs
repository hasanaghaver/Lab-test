using _01._04_lab.Models;

namespace _01._04_lab
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Customer customer1 = new Customer() { Name = "Elvin", City = "Baku" };
            Customer customer2 = new Customer() { Name = "Elnur", City = "Baku" };

            Courier courier1 = new Courier() { Name = "Ali", IsAvailable = true };
            Courier courier2 = new Courier() { Name = "Veli", IsAvailable = true };

            CargoOrder order1 = new CargoOrder() { CustomerId = 3, CourierId = 1 };
            
            CargoService cargoService = new CargoService();
            cargoService.AddCostumer(customer1);
            cargoService.AddCostumer(customer2);

            cargoService.AddCourier(courier1);
            cargoService.AddCourier(courier2);

            cargoService.CreateOrder(order1);


        }
    }
}
