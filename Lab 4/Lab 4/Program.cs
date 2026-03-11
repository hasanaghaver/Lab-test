namespace Lab_4
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //      1
            //Console.WriteLine("Eded daxil edin:");
            //int n = Convert.ToInt32(Console.ReadLine());
            //Console.WriteLine($"Daxil olunan {n} ededinin kvadrati: {Pow(n)}");

            //      2
            //Console.WriteLine("Eded daxil edin:");
            //int n = Convert.ToInt32(Console.ReadLine());
            //Console.WriteLine($"1-den daxil olunan {n} ededine qeder cem : {OnetoNSum(n)}");

            //      3
            //Console.WriteLine(Minnumber(8,2,3,4,5,7,1));

            //      4
            //Console.WriteLine(Counter('a',"adam"));

            //      5
            //Console.WriteLine($"1 ve 10 ededleri arasinda tek ededlerin sayi: {OddCount(1,10)}");

            //      6
            //Console.WriteLine("Soz daxil edin:\n(Bu proqram verilen sozun polindrom olsaini yoxlayir)");
            //string soz = Console.ReadLine();
            //Console.WriteLine(Polindrom(soz));

            //      7
            //    Console.WriteLine("Birinci ededi daxil edin:");
            //    int a = Convert.ToInt32(Console.ReadLine());
            //    Console.WriteLine("Ikinci ededi daxil edin:");
            //    int b = Convert.ToInt32(Console.ReadLine());
            //    Console.WriteLine("Emelliyati daxil edin: \nYalnizca * / + - kecerlidir");
            //    string c = "";
            //    while (true)
            //    {
            //        c = Console.ReadLine();
            //        if (c == "+"|| c=="-" || c=="*"|| c=="/")
            //        {
            //            break;
            //        }
            //        else
            //        {
            //            Console.WriteLine("Daxil etdiyiniz simvol standarta uygun deyil!");
            //        }
            //    }
            //    Console.WriteLine($"Emeliyyatin neticesi: {Emeliyyat(a,b,c)}");


            //      8
            Console.WriteLine("Bir metn daxil edin:");
            string soz = Console.ReadLine();
            NoneParabel(soz);
        }

        //      1
        public static int Pow(int i)
        {
            return i * i;
        }

        //      2
        public static int OnetoNSum(int n)
        {
            int cem = 0;
            for (int i = 1; i <= n; i++)
            {
                if (i % 2 == 0)
                {
                    cem += i;
                }
            }
            return cem;
        }

        //      3
        public static int Minnumber(params int[] i)
        {
            int min = i[0];
            for (int j = 0; j < i.Length; j++)
            {
                if (i[j] < min)
                {
                    min = i[j];
                }
            }
            return min;
        }
        //      4
        public static int Counter(char a, string b)
        {
            int count = 0;
            for (int i = 0; i < b.Length; i++)
            {
                if (a == b[i])
                {
                    count++;
                }
            }
            return count;
        }
        //      5
        public static int OddCount(int a, int b)
        {
            int oddCount = 0;
            for (int i = a; i < b; i++)
            {
                if (i % 2 != 0)
                {
                    oddCount++;
                }
            }
            return oddCount;
        }

        //      6
        public static bool Polindrom(string a)
        {
            string b = "";
            for (int i = a.Length - 1; i >= 0; i--)
            {
                b += a[i];
            }
            if (b == a)
            {
                return true;
            }
            return false;
        }
        //      7
        public static int Emeliyyat(int a, int b, string c)
        {
            switch (c)
            {
                case "+":
                    return a + b;
                case "-":
                    return a - b;
                case "*":
                    return a * b;
                case "/":
                    return a / b;
            }
            return -1;
        }
        //      8
        public static void NoneParabel(string a)
        {
            for (int i = 0; i < a.Length; i++)
            {
                if (a[i]!=' ')
                {
                    Console.Write(a[i]);
                }
            }
        }
    }
}
