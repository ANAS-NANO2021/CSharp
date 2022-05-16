using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DiziTest
{
    class Program
    {
        static void Main(string[] args)
        {

            int enb = 0, enk = 0;
            int[] Dizi = new int[9];
           

            Console.WriteLine("dizinin boyutunu bilerle ! : ");
            for (int i = 1; i < 5; i++)
            {
                Console.WriteLine(i + ".sayiyi gir : ");
                Dizi[i] = Convert.ToInt32(Console.ReadLine());

            }
            enk = Dizi[0];
            enb = Dizi[0];
            for (int i = 1; i < 5; i++)
            {
                if (enb < Dizi[i])
                {
                    enb = Dizi[i];
                   

                }
                if(enk > Dizi[i]  ) {

                    enk = Dizi[i];
                   

                }
            }
            Console.WriteLine("En kucuk sayi = " + enk);
            Console.WriteLine("Enbuyuk sayi = " + enb);

            Console.ReadLine();
        }
    }
}
