using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ikinci_Denklem
{
    class Program
    {
       /* public static void  BulDenklem(int a,int b,int c)
        {
            double x1, x2;
            double Delta = 0.0;
            
            Console.WriteLine("Denklem sekli (ax^2+bx+c = 0)");
            Delta = b * b - 4 * a * c;
            if (Delta > 0)
            {
                Console.WriteLine("iki koku vardir:  ");
                x1 = (-b + Math.Sqrt(Delta) )/( a * 2);
                x2 = (-b - Math.Sqrt(Delta)) / (a * 2);
                Console.WriteLine("x1 = " + x1 + "\n" + "x2 =" + x2);
            }

            else if (Delta == 0)
            {
                Console.WriteLine("bir koku vardir:  ");
                x1 = (-b )/( a * 2);
            }
            else
                Console.WriteLine("sanal koku yok");

        }*/
    public static void Buyuksayi(int n)
        {
            int gecici;
           
           /* Console.WriteLine("bir sayi gir : ");
            n = Convert.ToInt32(Console.ReadLine());*/
            int[] sayi = new int[n];


            for (int i = 0; i < n; i++)
            {
                Console.WriteLine(i + ".ici sayi gir : ");
                sayi[i] = Convert.ToInt32(Console.ReadLine());
            }
            for (int i = 0; i < n; i++)
            {
                for (int j = i+1; i < n; j++)
                {
                    if (sayi[i]< sayi[j])
                    {
                        gecici = sayi[i];
                        sayi[i] = sayi[j];
                        sayi[j] = gecici;
                    } 
                }
            }
            Console.WriteLine("dizide kucukten buyuga siralama : ");
            for (int i = 0;i<n; i++)
            {
                Console.WriteLine(sayi[i]);
            }

        }
       public static void Main(string[] args)
        {
            /*            BulDenklem(1, 6, 6);
             *            
            */
            Buyuksayi(8);
            Console.ReadKey();
            
        }
    }
}
