namespace Class_Task2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Vehicle vehicle = new("Mercedes","E280",1996);
            vehicle.StartEngine();
            vehicle.Drive(300);
            vehicle.StopEngine();
            vehicle.VehicleInfo();
            
        }
    }
}
