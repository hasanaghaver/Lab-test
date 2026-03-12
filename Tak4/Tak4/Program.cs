using System.Diagnostics;

namespace Tak4
{
    internal class Program
    {
        static void Main(string[] args)
        {

            // Task 1
            //Console.WriteLine("Bir eded daxil edin:");
            //int eded = Convert.ToInt32(Console.ReadLine());
            //ReqemSayi(eded);

            // Task 2
            //Console.WriteLine("Bir metn daxil edin:");
            //string metn = Console.ReadLine();
            //SaitSayi(metn);

            //Task3
            //MurekkebEdedCemi(1,13,22,5,3,6);

            //Task 4
            IndexFind(1, 2, 3, 4, 5, 6, 7, 8, 9);
        }
        public static void ReqemSayi(int a)
        {
            int count = 1;
            while (a > 9)
            {
                a /= 10;
                count++;
            }
            Console.WriteLine($"daxil edilen ededde reqem sasyi: {count}");
        }

        public static void SaitSayi(string a)
        {
            int count = 0;
            for (int i = 0; i < a.Length; i++)
            {
                switch (char.ToLower(a[i]))
                {
                    case 'a':
                        count++;
                        break;
                    case 'u':
                        count++;
                        break;
                    case 'o':
                        count++;
                        break;
                    case 'i':
                        count++;
                        break;
                    case 'e':
                        count++;
                        break;
                }
            }
            Console.WriteLine($"Daxil edilen ededde sait sayi: {count}");
        }

        public static void MurekkebEdedCemi(params int[] a)
        {
            int sum = 0;
            for (int i = 0; i < a.Length; i++)
            {
                for (int j = 2; j < a[i]; j++)
                {
                    
                    if (a[i] % j == 0)
                    {
                        sum += a[i];
                        break;
                    }
                }
            }
            Console.WriteLine(sum);
        }

        public static void IndexFind(params int[] a)
        {
            int index = -1;
            for (int i = 0; i < a.Length; i++)
            {
                if (a[i]==7)
                {
                    index = i;
                }
            }
            if (index == -1)
            {
                Console.WriteLine("Not found");
            }
            else
            {
                Console.WriteLine($"7 reqemi {index} - indexdedir");
            }
        }

    }
}
