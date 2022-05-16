using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ogr_ortalamasi1
{
    class Program
    {
        static void Main(string[] args)
        {
            int ogr_sayisi;
            Console.WriteLine("ogrencilerin sayisini gir : ");
            ogr_sayisi = Convert.ToInt32(Console.ReadLine());

            double [] VizeNotu = new double[10];
            double [] FinalNote = new double[10];
            double [] VizeOrtalamasi = new double[10];
            double [] FinalOrtalamasi= new double[10];
           /* double [] Ogr_sayisi = new double[ogr_sayisi];*/
            double [] NotOrtalamasi = new double[10];
            double[] but_notu = new double [10];
            double sinifOrtalama;
            for (int i = 1; i <= ogr_sayisi; i++)
            {
              Console.Write(i + ".ogrencinin Vize notunu gir : ");

                VizeNotu[i] = Convert.ToInt32(Console.ReadLine());
                VizeOrtalamasi[i] = VizeNotu[i] * 0.4;

                Console.Write(i + ".ogrencinin Final notunu gir : ");
                FinalNote[i] = Convert.ToInt32(Console.Read());
                FinalOrtalamasi[i] = FinalNote[i] * 0.6;
                
                NotOrtalamasi[i] = VizeNotu[i] * 0.4 + FinalNote[i] * 0.6;

            }
            for (int j = 1; j <= ogr_sayisi; j++)
            {
                

                Console.WriteLine(j + ".Ogrenci Vize Ortalamasi = " + VizeOrtalamasi[j]);
                Console.WriteLine(j + ".Ogrenci Final Ortalamasi = " + FinalOrtalamasi[j]);
               /* if (FinalOrtalamasi[j] >= 60)
                {
                    Console.WriteLine(j + " .Ogrenci Derstengecti .Not Oratalmasi = " + NotOrtalamasi[j]);
                }
                else
                {
                    Console.WriteLine("butuleme sinavina giriecek ");
                    Console.WriteLine("Butleme notunu gir : ");
                    but_notu[j] = Convert.ToInt32(Console.ReadLine()); 

                    if (but_notu[j] >= 60)
                    {
                        Console.WriteLine(j + " .Ogrenci Derstengecti .Not Oratalmasi = " + NotOrtalamasi[j]);
                    }
                    else
                    {
                        Console.WriteLine("Dersten kalmis ..... ortalama = "+NotOrtalamasi[j]);
                    }
                    
                }*/
               sinifOrtalama = NotOrtalamasi[j] / ogr_sayisi;
            }

            Console.ReadKey();

        }
    }
}
