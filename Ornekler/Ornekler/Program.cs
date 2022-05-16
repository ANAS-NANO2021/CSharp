using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ornekler
{
    class Program
    {
        static void Main(string[] args)
        {
            int Kalan = 0, gecer = 0, durum;
           
            for (int i = 0; i < 8; i++)
            {
                Console.WriteLine("enter the situation : ");
                durum = Convert.ToInt32(Console.ReadLine());
                if (durum == 1)
                {
                    gecer += 1;
                }
                else
                {
                    Kalan += 1;

                }

            }
            Console.WriteLine("gecer sayisi : " + gecer);
            Console.WriteLine("kalan sayisi : " + Kalan);


            Console.ReadKey();
        }
    }
}
