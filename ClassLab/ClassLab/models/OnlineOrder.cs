using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http.Headers;
using System.Text;
using System.Threading.Tasks;

namespace ClassLab.models
{
    class OnlineOrder : Order
    {

        public double Distance;

        public OnlineOrder(int id, string productName, int count, double price, double distance) : base(id, productName, count, price)
        {
            Distance = distance;
        }

        public double DistancePrice()
        {
            return (Distance / 5) * 2;
        }
        public void OnlineOrdeeInfo()
        {
            Console.WriteLine($"Sifariş ID: {Id} \nMehsul: {name} \nSayı:{count} \nQiymet:{price} \nUmumi Mebleg:{MehsulQiymetiSum()}" +
                $" \nCatdirilma: {DistancePrice()} \nUmumu mebleg catdirilma ile: {MehsulQiymetiSum()+DistancePrice()}");
        }

    }
}
