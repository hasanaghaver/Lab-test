//      1
//string a = Console.ReadLine();
//int b = 0;
//for (int i = 0; i < a.Length; i++)
//{
//    if (a[i] == 'a')
//    {
//        b = 1;
//        break;
//    }
//}
//if (b > 0)
//{
//    Console.WriteLine("Daxil olunmus metnde a herfi var");
//}
//else
//{
//    Console.WriteLine("Daxil olunmus metnde a herfi yoxdur");
//}

//      2
//string a = Console.ReadLine();
//int b = 0;
//for (int i = 0; i < a.Length; i++)
//{
//    if (a[i] == 'a')
//    {
//        b ++;
//    }
//}
//if (b > 0)
//{
//    Console.WriteLine($"Daxil olunmus metnde {b} a herfi var");
//}
//else
//{
//    Console.WriteLine("Daxil olunmus metnde a herfi yoxdur");
//}

//     3
//int[] a = [1, 2, 3, 4, 5, 6, 7, 8, 9];
//int cem = 0;
//for (int i = 0; i < a.Length; i++)
//{
//    if (a[i] % 2 == 0)
//    {
//        cem += a[i];
//    }
//}
//Console.WriteLine($"Verilmis arrayda cut ededlerin cemi: {cem} ");

//      4
//string[] yazilar = ["salam", "adam", "baba"];
//int say = 0;
//for (int i = 0; i < yazilar.Length; i++)
//{
//    string a= yazilar[i];
//    for (int j = 0; j < yazilar[i].Length; j++)
//    {
//        if (a[j] =='a')
//        {
//            say++;
//        }
//    }
//}
//Console.WriteLine($"Yazilar siyahisinda {say}-eded a var");

//      5
//int[] ededler = [5,4,6];
//for (int i = 0; i < ededler.Length; i++)
//{
//    int faktorial = 1;
//    for (int j = 1; j <= ededler[i]; j++)
//    {
//        faktorial = faktorial * j;
//    }
//    Console.Write(faktorial + ",");
//}


//      6
//int[] a = [7,12,5,8];
//int b = a[1];
//for (int i = 0; i < a.Length; i++)
//{
//    if (b > a[i])
//    {
//        b = a[i];
//    }
//}
//for (int i = 0; i < a.Length; i++)
//{
//    if (a[i] != b)
//    {
//        Console.Write(a[i] + " ");
//    }
//}


//      7
int n = Convert.ToInt32(Console.ReadLine());
int m = Convert.ToInt32(Console.ReadLine());

for (int i = n; i < m; i++)
{
    string b = Convert.ToString(i);
    string c = "";
    for (int j = b.Length-1; j >= 0; j--)
    {
        c += b[j];
    }
    if (c == b)
    {
        Console.WriteLine(b);
    }
}


