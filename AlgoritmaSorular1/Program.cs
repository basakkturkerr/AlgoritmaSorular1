using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AlgoritmaSorular1
{
    class Program
    {
        static void Main(string[] args)
        {
          // // 10 - 12 - 14 - 15 - 16 - 17 - 18 - 19 - 21 - 22 - 23 - 24 sonra yapılacak.

          //  // 1. Dışarıdan girilen bir N sayısına kadar olan sayıların toplamını bulan program.

          //  Console.WriteLine("Bir N sayısı giriniz:");
          //  int N = Convert.ToInt32(Console.ReadLine());

          //  int toplam = ((N * (N + 1)) / 2);

          //  Console.WriteLine("N sayısına kadar olan sayıların toplamı:" + ' ' + toplam);
          //  Console.ReadLine();


          //  // 2. Dışarıdan girilen bir N sayısına kadar olan tek sayıların toplamını bulan program.

          //  Console.WriteLine("Bir N sayısı giriniz:");
          //  int N = Convert.ToInt32(Console.ReadLine());

          //  int n = ((N + 1) / 2);
          //  int toplam = (n * n);

          //  Console.WriteLine("N sayısına kadar olan tek sayıların toplamı:" + toplam);
          //  Console.ReadLine();


          // // 3.Yarıçapı dışarıdan girilen bir dairenin çevresini ve alanını bulan program.

          //  Console.WriteLine("Çemberin yarıçapını giriniz.");
          //  double r = Convert.ToDouble(Console.ReadLine());

          //  double cevre = 2 * Math.PI * r;
          //  Console.WriteLine("Çemberin Çevresi:" + ' ' + cevre);

          //  double alan = Math.PI * r * r;
          //  Console.WriteLine("Çemberin Alanı:" + ' ' + alan);

          //  Console.ReadLine();


          ////  4.Katsayıları dışarıdan girilen ikinci dereceden bir denklemin çözüm kümesini bulan program. 
          ////  (ax ^ 2 + bx + c) = 0 ikinci derece denkleminin köklerini bulmak için öncelikle(delta)’nın bulunması gerekir.

          //  Console.WriteLine("1.katsayıyı giriniz.");
          //  double a = Convert.ToDouble(Console.ReadLine());

          //  Console.WriteLine("2.katsayıyı giriniz.");
          //  double b = Convert.ToDouble(Console.ReadLine());

          //  Console.WriteLine("3.katsayıyı giriniz.");
          //  double c = Convert.ToDouble(Console.ReadLine());

          //  double d = ((b * b) - (4 * a * c));

          //  if (d < 0)
          //  {
          //      Console.WriteLine("Reel kök yok");
          //  }

          //  else if (d == 0)
          //  {
          //      double x = -b / (2 * a);
          //      Console.WriteLine("Denklemin kökü:" + ' ' + x);
          //  }

          //  else
          //  {
          //      double x1 = ((-b) - (Math.Sqrt(d))) / (2 * a);
          //      Console.WriteLine("Denklemin birinci kökü:" + ' ' + x1);

          //      double x2 = ((-b) + (Math.Sqrt(d))) / (2 * a);
          //      Console.WriteLine("Denklemin ikinci kökü:" + ' ' + x2);
          //  }

          //  Console.ReadLine();


          //  //5.Kendisi hariç tam bölenlerinin toplamı kendisine eşit olan sayılara “mükemmel sayılar” denir.
          //  // Dışarıdan girilen bir N sayısına kadar olan mükemmel sayıları listeleyen program.

          //  Console.WriteLine("Bir N sayısı giriniz");
          //  int N = Convert.ToInt32(Console.ReadLine());
          //  int ktoplam;

          //  for (int i = 1; i <= N; i++)
          //  {
          //      ktoplam = 0;

          //      for (int k = 1; k < i; k++)
          //      {
          //          if (i % k == 0)
          //          {
          //              ktoplam = ktoplam + k;
          //          }
          //      }

          //      if (ktoplam == i)
          //      {
          //          Console.WriteLine("Mükemmel Sayılar:" + i);
          //      }
          //  }

          //  Console.ReadLine();


          //  // 6. Dışarıdan girilen bir sayının rakamları toplamını bulan program.

          //  Console.WriteLine("Bir sayı giriniz");
          //  int sayi = Convert.ToInt32(Console.ReadLine());
          //  int toplam = 0;
          //  int basamak;

          //  while (sayi > 0)
          //  {
          //      basamak = sayi % 10;
          //      sayi = (sayi - basamak) / 10;
          //      toplam = toplam + basamak;
          //  }

          //  Console.Write("girdiginiz sayinin basamakları toplamı : " + toplam);
          //  Console.Read();


          //  // 7. Dışarıdan girilen bir sayının rakamlarını tersine çeviren program.

          //  Console.WriteLine("Bir sayı giriniz");
          //  int sayi = Convert.ToInt32(Console.ReadLine());
          //  int basamak;
          //  while (sayi > 0)
          //  {
          //      basamak = sayi % 10;
          //      sayi = (sayi - basamak) / 10;
          //      Console.Write(basamak);
          //  }

          //  Console.Read();


          //  // 8. Dışarıdan girilen üç değişkenden en büyük olanı bulan program.

          //  Console.WriteLine("Birinci sayıyı giriniz");
          //  double sayi1 = Convert.ToDouble(Console.ReadLine());

          //  Console.WriteLine("İkinci sayıyı giriniz");
          //  double sayi2 = Convert.ToDouble(Console.ReadLine());

          //  Console.WriteLine("Üçüncü sayıyı giriniz");
          //  double sayi3 = Convert.ToDouble(Console.ReadLine());

          //  if (sayi1 > sayi2 && sayi1 > sayi3)
          //  {
          //      Console.WriteLine("En büyük sayı: " + sayi1);
          //  }

          //  else if (sayi2 > sayi1 && sayi2 > sayi3)
          //  {
          //      Console.WriteLine("En büyük sayı: " + sayi2);
          //  }

          //  else
          //  {
          //      Console.WriteLine("En büyük sayı: " + sayi3);
          //  }

          //  Console.ReadLine();


          //  // 9. Dışarıdan girilen bir N sayısına kadar olan sayıların karelerinin toplamını hesaplayan program.

          //  Console.WriteLine("Bir N değeri giriniz");
          //  int n = Convert.ToInt32(Console.ReadLine());

          //  Console.WriteLine("N sayısına kadar olan sayıların karelerinin toplamı :" + (n * (n + 1) * ((2 * n) + 1)) / 6);
          //  Console.ReadLine();


          // // 10.Dışarıdan girilen herhangi bir ondalıklı sayıyı, tam ve ondalıklı kısımlarına ayıran program. ?????


          // // 11. Dışarıdan girilen N tane sayının ortalamasını bulan program.
          //  string yes = "y";
          //  int sayac = 0;
          //  double toplam = 0;
          //  double sayi;

          //  Console.WriteLine("ortalaması alınacak sayıları giriniz: ");
          //  while ("y".Equals(yes))
          //  {
          //      Console.WriteLine("sayi giriniz : ");
          //      sayi = Convert.ToDouble(Console.ReadLine());
          //      sayac++;
          //      toplam += sayi;
          //      Console.WriteLine("yeni sayi girecek misiniz? (y) (n)");
          //      yes = Console.ReadLine();
          //  }
          //  Console.Write("Ortalama : " + toplam / sayac);
          //  Console.ReadLine();


          //  // 12. Aşağıdaki formu ekrana yazdıran program. ?????
          //  // 2  3   4   5   6
          //  // 3  5   7   9   11
          //  // 4  7   10  13  16
          //  // 5  9   13  17  21
          //  // 6  11  16  21  26

          //  for (int i = 1; i < 6; i++)
          //  {
          //      for (int k = 1; k < 6; k++)
          //      {

          //          Console.Write(k + i);
          //          Console.Write(' ');

          //      }
          //      Console.WriteLine();
          //      a++;

          //  }
          //  Console.ReadLine();


          //  // 13. Aşağıdaki formu ekrana yazdıran program.
          //  //      *
          //  //    * * *
          //  //  * * * * *
          //  //* * * * * * *

          //  for (int i = 1; i < 8; i++)
          //  {
          //      if (i % 2 == 1)
          //      {
          //          for (int k = i; k <= 5; k++)
          //          {
          //              Console.Write(' ');
          //          }

          //          for (int l = 1; l <= i; l++)
          //          {
          //              Console.Write('*');
          //              Console.Write(' ');
          //          }
          //          Console.WriteLine();
          //      }
          //  }
          //  Console.ReadLine();


          //// 14.Dışarıdan girilen iki sayının OKEK’ini bulan program. ?????


          //// 15. 1’den 999’a kadar olan sayılar içerisinden basamaklarının küpleri toplamı kendisine eşit olan sayıları bulan program. ?????


          //// 16.Dışarıdan girilen N sayısına kadar olan asal sayıları bulan program. ?????


          //// 17. Bazı sayılar sırası ile 2,3,4,5,6,7,8,9,10’a bölündüklerinde yine sırası ile 1,2,3,4,5,6,7,8,9 kalanlarını vermektedir. 
          ////   Dışarıdan girilen N sayısına kadar olan sayılardan bu özelliği taşıyan sayıları listeleyen program. { Örnek 2519}. ?????


          //// 18.İkilik tabanda verilen bir sayıyı onluk tabana çeviren program. ?????


          //// 19.Onluk tabanda verilen bir sayıyı ikilik tabana çeviren program. ?????


          //// 20. Aşağıdaki formu ekrana yazdıran program.
          ////  1
          ////  2  3
          ////  4  5  6
          ////  7  8  9  10
          ////  11 12 13 14 15

          //  int toplam = 0;

          //  for (int i = 1; i < 6; i++)
          //  {
          //      for (int j = 1; j <= i; j++)
          //      {
          //          toplam += 1;
          //          Console.Write(toplam);
          //          Console.Write(' ');
          //      }
          //      Console.WriteLine();
          //  }
          //  Console.ReadLine();


          // // 21. Çarpma işlemini kullanmadan dışarıdan girilen iki sayının çarpımını bulan program ?????


          // // 22. Dışarıdan üç kenarının uzunluğu girilen bir üçgenin ne çeşit bir üçgen olduğunu bulan program ?????


          // // 23. Dışarıdan girilen iki sayının OBEB’ini bulan program ?????


          // // 24. Dışarıdan girilen bir tamsayının rakamları arasındaki en büyük sayıyı bulan program ?????


           // 25. Aşağıdaki formu ekrana basan program.
           // 1
           // 2  1
           // 3  2  1
           // 4  3  2  1
           // 5  4  3  2  1

            int k = 0;

            for (int i = 1; i < 6; i++)
            {
                for (int j = 0; j < i; j++)
                {
                    Console.Write(k - j + 1);
                    Console.Write(' ');
                }
                k++;
                Console.WriteLine();
            }
            Console.ReadLine();


        }
    }
}
