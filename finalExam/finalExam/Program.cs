using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace finalExam
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World");
            ushort sayi;
            for (ushort i = 1; i <= 5; i++)
            {
                sayi = i;

                Console.WriteLine("sayi = " + sayi);
                sayi = (ushort)(sayi & 0xFFFE);
                Console.WriteLine("Sonuc = " + sayi + "\n");
            }
            Console.ReadKey();
        }
    }
}
