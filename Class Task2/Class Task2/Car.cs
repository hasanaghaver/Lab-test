using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Class_Task2
{
    class Car:Vehicle
    {
        private double _fuelCapacity;
        private double _fuel;
        public double _fuelConsumptionPer100Km;

        public double FuelCapacity
        {
            get { return _fuelCapacity; }
            set { if (value > 0) { _fuelCapacity = value; } else { Console.WriteLine("Deyer musbet olmalidir!");} }
        }

        public double Fuel
        {
            get { return _fuel; }
            set { if (value > 0) { _fuel = value; } else { Console.WriteLine("Deyer musbet olmalidir!"); } }
        }

        public Car(string Brand, string Model, int Year,double FuelCapacity, double Fuel, double FuelConsumptionPer100Km)
            :base(Brand,Model,Year)
        {
            _fuelCapacity = FuelCapacity;
            _fuel = Fuel;
            _fuelConsumptionPer100Km = FuelConsumptionPer100Km;
        }

        public void Refuel(double liters)
        {
            if (_fuel + liters <= _fuelCapacity)
            {
                _fuel += liters;
            }
            else
            {
                Console.WriteLine("Bu qeder benzin doldura bilmezsiniz");
            }
        }
    }
}
