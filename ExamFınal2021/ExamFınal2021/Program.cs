using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExamFınal2021
{
    class Program
    {
        public static void Ekok()
        {
            /* int[] sayi = new int[10];
             int ekok = 0;
             for (int i = 1; i <= 3; i++)
             {
                 Console.Write(i + ".sayi: ");
                 sayi[i] = Convert.ToInt32(Console.ReadLine());


             }
             for (int i = 1; i <= 3; i++)
             {
                 if (sayi[i]% i == 0 && ekok != 1&& sayi[i+1] % i == 0&& sayi[i+2] % i == 0)
                 {
                     ekok = i;
                     Console.WriteLine("Ekok = " + ekok);
                 }
             }*/
            /* int [] saatucreti = new int[10];
             int[] calisilansaat = new int[10];
             int[] aymassi = new int[10];
             int [] urunadedi = new int[10];

            for (int i = 1; i < 2; i++) { 
                 Console.WriteLine(i+".isci icin saat ucretini :  ");
                 calisilansaat[i] = Convert.ToInt32(Console.ReadLine());
                 Console.WriteLine(i+ ".isci icin calisilan saatini  gir:  ");
                 saatucreti[i] = Convert.ToInt32(Console.ReadLine());
                 aymassi[i] = calisilansaat[i] * saatucreti[i];

                 Console.WriteLine(i + ".Urrun adedi gir   :  ");
                 urunadedi[i] = Convert.ToInt32(Console.ReadLine());



             }
             for (int i = 1; i < 2; i++)

                 {
                 Console.WriteLine(aymassi[i] + " ________\n" + urunadedi[i]);

             }*/
            /*   int[] nums = new int[10];
               Console.WriteLine("dort basamakli sayi gir : ");
               for (int i = 1; i < 5; i++)
               {
                   Console.WriteLine(i+". basamak  gir:  ");
                   nums[i] = Convert.ToInt32(Console.ReadLine());

               }
               for (int i = 1; i < 5; i++)
               {
                   switch (nums[i]) {
                       case 1:
                           Console.Write("One");
                           break;
                       case 2:
                           Console.Write("Two");
                           break;
                       case 3:
                           Console.Write("Three");
                           break;
                       case 4:
                           Console.Write("Four");
                           break;
                   }


               }

                   Console.ReadKey();*/
            int[] sayilar = new int[100];
            Random rnd = new Random();
            int min = 0, mak = 0;

            for (int i = 0; i < sayilar.Length; i++)
            {
                sayilar[i] = rnd.Next(1, 100);
                Console.WriteLine(sayilar[i]);
            }

            for (int i = 1; i < sayilar.Length; i++)
            {
                if (min < sayilar[i])
                    min = sayilar[i];
                if (mak > sayilar[i])
                    mak = sayilar[i];
            }
            Console.WriteLine("=====================================");
            Console.WriteLine("www.yazilimkodlama.com");
            Console.WriteLine("=====================================");
            Console.WriteLine("Dizi içindeki en büyük sayı:>>" + mak);
            Console.WriteLine("Dizi içindeki en küçük sayı:>>" + min);
            Console.ReadKey();
        }
        static void Main(string[] args)
        {
            Ekok();
        }
    }
}
