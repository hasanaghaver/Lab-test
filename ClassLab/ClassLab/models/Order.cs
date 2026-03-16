using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;

namespace ClassLab.models
{
    class Order
    {
        public int Id;
        public string name;
        public int count;
        public double price;
        double diff;
        public Order(int id, string MehsulAdi, int MehsulSayi, double MehsulQiymeti)
        {
            Id = id;
            name = MehsulAdi;
            count = MehsulSayi;
            price = MehsulQiymeti;
        }
        public Order(int id, string MehsulAdi, double MehsulQiymeti)
        {
            Id = id;
            name = MehsulAdi;
            count = 1;
            price = MehsulQiymeti;
        }

        public double MehsulQiymetiSum()
        { 
            return count*price;
        }

        public void MehsulSayiArtir(int n)
        {
            count += n;
            Console.WriteLine($"Mehsulun sayi {count} oldu");
        }

        public void Getinfo()
        {
            Console.WriteLine($"Sifariş ID: {Id} \nMehsul: {name} \nSayı:{count} \nQiymet:{price} \nUmumi Mebleg:{MehsulQiymetiSum()}");
        }

        public void ChangePrice(double newPrice, out double diff)
        {
            diff = newPrice-price; 
            price = newPrice;
        }
    }
}
