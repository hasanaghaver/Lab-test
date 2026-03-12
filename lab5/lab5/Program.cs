using System.Numerics;

namespace lab5
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // Task 1
            //Console.WriteLine("Eded daxil edin");
            //int n = Convert.ToInt32(Console.ReadLine());
            //IkiReqemliSayi(n);

            //Task2
            //Console.WriteLine("iki ededin quveti hesablanacaq ededleri daxil edin");
            //int n = Convert.ToInt32(Console.ReadLine());
            //int m = Convert.ToInt32(Console.ReadLine());
            //Pow(n, m);

            //Task 3
            //BeseBolunenlerinCemi(1,10,20,3);

            //task 4
            //MaxInArray(3,234,123,42354,33,53,23);

            //Task5
            //Console.WriteLine("iki eded daxil edin o ededllerden yaranan en boyuk ededi yaradaq");
            //int n = Convert.ToInt32(Console.ReadLine());
            //int m = Convert.ToInt32(Console.ReadLine());
            //EnBoyukReqem(n, m);

            //task 6
            //Console.WriteLine(StringBirlesdirme("salam","necesen"));

            //task 7
            //EdedlerinCemi(1,2,3,4,5,6,7,8,9,10);

            //task 8
            Console.WriteLine("Uc eded daxil edin o ededllerden yaranan en boyuk ededi yaradaq");
            int n = Convert.ToInt32(Console.ReadLine());
            int m = Convert.ToInt32(Console.ReadLine());
            int t = Convert.ToInt32(Console.ReadLine());
            EnBoyukReqem3(n, m,t);

        }


        public static void IkiReqemliSayi(int a)
        {
            int count = 0;
            for (int i = 10; i < a; i++)
            {
                if (i < 100)
                {
                    count++;
                }
            }
            Console.WriteLine($"1 den {a}-ya qeder iki reqemli ededlerin sayi: {count}");
        }

        public static void Pow(int a, int b)
        {
            int result = a;
            for (int i = 1; i < b; i++)
            {
                result *= a;
            }
            Console.WriteLine($"{a} ustu {b} = {result}");
        }

        public static void BeseBolunenlerinCemi(params int[] a)
        {
            int cem = 0;
            for (int i = 0; i < a.Length; i++)
            {
                if (a[i] % 5 == 0)
                {
                    cem += a[i];
                }
            }
            Console.WriteLine(cem);
        }

        public static void MaxInArray(params int[] a)
        {
            int max = a[0];
            for (int i = 0; i < a.Length; i++)
            {
                if (a[i] > max)
                {
                    max = a[i];
                }
            }
            Console.WriteLine($"Massivin en boyuk elementi: {max}");
        }

        public static void EnBoyukReqem(int a,int b)
        {
            int eded = 0;
            if (a > b)
            {
                eded = a*10 + b;
            }
            else
            {
                eded = b*10+ a;
            }
            Console.WriteLine($"Daxil edilmis {a} ve{b} ededinden yaradilmis en boyuk eded: {eded}");
        }

        public static string StringBirlesdirme(params string[] a)
        {
            string result = "";
            for (int i = 0; i < a.Length; i++)
            {
                result += a[i] + " ";
            }
            return result;
        }

        public static void EdedlerinCemi(params int[] a)
        {
            int cem = 0;
            for (int i = 0; i < a.Length; i++)
            {
                cem += a[i];
            }
            Console.WriteLine(cem);
        }

        public static void EnBoyukReqem3(int a, int b, int c)
        {
            int[] mas = [a, b, c];
            int max = mas[0];
            int min = mas[0];
            int ort = mas[0];
            for (int i = 0; i < mas.Length; i++)
            {
                if ( mas[i] > max)
                {
                    max = mas[i];
                }
            }
            for (int i = 0; i < mas.Length; i++)
            {
                if (mas[i] < min)
                {
                    min = mas[i];
                }
            }
            for (int i = 0; i < mas.Length; i++)
            {
                if (mas[i]<max && mas[i] > min)
                {
                    ort = mas[i];
                }
            }
            Console.WriteLine(max*100+ort*10+min);

        }
    }
}
