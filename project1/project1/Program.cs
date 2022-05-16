using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace project1
{
    class Program
    {
        static void Main(string[] args)
        {
            byte sayi1 = 192;
            byte sayi2 = (byte)  sayi1;

            Console.WriteLine("sayi2");

            byte sayi3 = 147;
            byte sayi = 75;
            int sayi5 = (byte)(sayi3 & sayi);

            Console.WriteLine(sayi5);
            byte sayi6 = (byte)(0x82 & 0xEC | 0x1);

            Console.WriteLine("0xB2 & 0xEC | 0x1 = " + sayi6);

            byte sayi7 = 10;
            byte sayi8 = (byte)(sayi7 << 1);
            Console.WriteLine("10 << 1 = "+sayi8);
            Console.WriteLine($"<< 2= {sayi7 << 2}");


            Console.ReadLine();







        }
    }
}
