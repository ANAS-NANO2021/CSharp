using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ebk
{
    class Program
    {
        public static void Enbuyuk()
        {
            Random r = new Random();

            int[] nums = new int [100];
            int Max = 0, Min = 0;
            for (int i = 1; i <= 80; i++)
            {
                nums[i] = r.Next(1, 1000);
                if (Max < nums[i])
                {
                    Max= nums[i];

                }
                if (Min > nums[i])
                {
                    Min = nums[i];

                }
            //   Console.WriteLine(i + ".number[" + i + "] = " + nums[i]);
            }
            Console.WriteLine("En buyuk = : " + Max);
            Console.WriteLine("En Kucuk = : " + Min);
        }
       /* public static void Aramakfanksiyonu()
        {

            int[] numbers = new int[5];
            int s;
            for (int i = 0; i < numbers.Length; i++)
            {
                Console.WriteLine("nums[" + i + "] : ");
                numbers[i] = Convert.ToInt32(Console.ReadLine());

            }
            for (int j = 0; j < numbers.Length; j++)
            {
                Console.WriteLine("nums[" + j + "] = " + numbers[j]);

            }
            Console.Write("aradiginiz degeri giriniz: ");
            s = Convert.ToInt32(Console.ReadLine());
            for (int i = 0; i<numbers.Length; i++)
            {
               
                if (s == numbers[i])
                {
                    Console.WriteLine(s + " degeri bulundu !");
                }
            }
            }*/

        static void Main(string[] args)
        {
            Enbuyuk();

            //  Aramakfanksiyonu();
          /*  ushort s;
            for (ushort i = 1; i <= 5; i++)
            {
                s = i;
                Console.WriteLine("sayi : " + s);
                s = (ushort) (s & 0xFFFE);
                Console.WriteLine("Sonuc  = " + s + "\n");
            }*/
          
            Console.ReadLine();
        }
    }
}
