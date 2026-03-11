//int a = 0;
//if (a > 0)
//{
//    Console.WriteLine("Eded musbetdir");
//}else if (a == 0)
//{
//    Console.WriteLine("Eded 0-dir");
//}
//else
//{
//    Console.WriteLine("Eded menfidir");
//}

//}
//Console.WriteLine("Yasinizi daxil edin:");
//int age = Convert.ToInt32(Console.ReadLine());
//if(age>0 && age < 18)
//{
//    Console.WriteLine("usaq");
//}else if(age>=18 && age < 65)
//{
//    Console.WriteLine("yetiskin");
//}
//else
//{
//    Console.WriteLine("yasli");
//}

//Console.WriteLine("Mehsulun qiymetini daxil edin:");
//int mebleg = Convert.ToInt32(Console.ReadLine());
//if (mebleg < 100)
//{
//    Console.WriteLine($"Mehsulun qiymeti {mebleg}.Endirim tetbiq olunmur.");
//}
//else if(mebleg>=100 && mebleg <= 500)
//{
//    mebleg = (mebleg * 90) / 100;
//    Console.WriteLine($"Mebleg {mebleg} oldu. 10% edirim olundu");
//}
//else
//{
//    mebleg = (mebleg * 80) / 100;
//    Console.WriteLine($"Mebleg {mebleg} oldu. 20% edirim olundu");
//}

//Console.WriteLine("(2-5 araliginda) Ededi daxil edin:");
//int a = Convert.ToInt32(Console.ReadLine());
//switch (a)
//{
//    case 2:
//        Console.WriteLine("Pis");
//        break;
//    case 3:
//        Console.WriteLine("Kafi");
//        break;
//    case 4:
//        Console.WriteLine("Yaxsi");
//        break;
//    case 5:
//        Console.WriteLine("Ela");
//        break;
//    default:
//        Console.WriteLine("Eded 2-5 araligina daxil deyil");
//        break;
//}

//Console.WriteLine("Hans; ededin faktorialini hesablamaq lazimdir?");
//int a = Convert.ToInt32(Console.ReadLine());
//int s = 1;
//for(int i=2; i<=a; i++)
//{
//    s = s * i;
//}
//Console.WriteLine($"{a} ededinin faktoriali {s}");


Console.WriteLine("Hansi edede qeder hesablanmalidir?");
int a = Convert.ToInt32(Console.ReadLine());
int s = 0;
for (int i = 1; i <= a; i++)
{
    s +=  i;
}
Console.WriteLine($"{a} -ya qeder ededlerin cemi {s}");