using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace project
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Bir sayi giriniz: ");
            int sayi = Convert.ToInt32(Console.ReadLine());
            int sayac = 0;
            while (sayi > 0)
            {

                sayi /= 10;
                sayac++;

            }
            Console.WriteLine("Girdiginiz sayi " + sayac + " basamaklıdır.");

            Console.ReadLine();
        }
    }
}