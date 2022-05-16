
   

using System;
using System.Collections;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    class Program
    {

        static int essizDegerler(int[] arr, int n)
        {
            for (int i = 0; i < n; i++)
            {
                for (int j = i + 1; j < n;)
                {
                    // 1 2 2 3 4 4 5 6 6 5 5 5 5 
                    if (arr[i] == arr[j])
                    {
                        for (int k = j; k < n - 1; k++)
                        {
                            arr[k] = arr[k + 1];
                        }
                        n--;
                    }
                    else
                    {
                        j++;
                    }
                }
            }
            return n;
        }

        static void Main(string[] args)
        {
            int[] arr;
            int size;

            while (true)
            {
                Console.Write("Dizi boyutunu girin: ");
                // girilen değerin sayıya dönüştürülüp dönüştürülmeyeceğini kontrol eder.
                bool flag = int.TryParse(Console.ReadLine(), out size);

                if (flag)
                {
                    if (size > 0)
                    {
                        arr = new int[size];
                        for (int i = 0; i < size; i++)
                        {
                            Console.Write("{0}. eleman: ", i + 1);
                            flag = int.TryParse(Console.ReadLine(), out int num);
                            if (flag)
                            {
                                arr[i] = num;
                            }
                            else
                            {
                                Console.WriteLine("Lütfen sayi girin.");
                            }
                        }
                        essizDegerler(arr, size);
                        break;
                    }
                    else
                    {
                        Console.WriteLine("Girdiğiniz değer 0'dan küçüktür.");
                    }
                }
                else
                {
                    Console.WriteLine("Lütfen sayı giriniz.");
                }
            }


            Console.WriteLine("Orjinal Diziyi Göster: ");
            for (int i = 0; i < arr.Length; i++)
            {
                Console.WriteLine(arr[i]);
            }


            Console.WriteLine("Eşsiz Değerli Diziyi Göster: ");

            int newSize = essizDegerler(arr, size);

            for (int i = 0; i < newSize; i++)
            {
                Console.WriteLine(arr[i]);
            }


            Console.ReadLine();

        }
    }

}