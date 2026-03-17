

namespace Class_Task2
{
    class Vehicle
    {
        private string _brand;
        private int _year;
        public string Model;
        public int MileageKm;
        public bool IsRunning;


        public string Brand
        {
            get { return _brand; }
            set
            {
                if (value.Length > 3) { _brand = value; } else { Console.WriteLine("3 simvoldan az ola bilmez"); }
            }
        }
        public int Year
        {
            get
            {
                return _year;
            }
            set
            {
                if (value > 1900) { _year = value; } else { Console.WriteLine("Il 1900-den cox olmalidir"); }
            }
        }
        public Vehicle(string Brand, string Model, int Year)
        {
            _brand = Brand;
            this.Model = Model;
            _year = Year;
        }

        public bool StartEngine()
        {
            IsRunning = true;
            return IsRunning;
        }
        public bool StopEngine()
        {
            IsRunning = false;
            return IsRunning;
        }
        public void Drive(int km)
        {
            if (IsRunning)
            {
                MileageKm += km;
                Console.WriteLine(MileageKm);
            }
            else
            {
                Console.WriteLine("Surus mumkun deyil! \nOnce avtomobili ise sal");
            }
        }
        public void VehicleInfo()
        {
            Console.WriteLine($"Brand: {_brand} \nModel: {Model} \nYear: {_year} \nMillage: {MileageKm} \nRuning {IsRunning}");
        }
    }
}
