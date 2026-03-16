using ClassLab.models;

namespace ClassLab
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //https://github.com/novruzoff9/APA202/tree/main/03.16
            double diff;
            Order order1 = new(1, "Alma",2,  2.5);

            OnlineOrder order2 = new(1, "Armud", 3, 3.5, 15);

            order2.OnlineOrdeeInfo();
        }
    }
}
