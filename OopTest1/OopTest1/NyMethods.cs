using System;

namespace OopTest1
{
    internal class NyMethods
    {
        public  void Test(int sayi)
        {
            int yuzler, onlar, birler;
            yuzler = sayi / 100;
            Console.WriteLine("yuzler : " + yuzler);
            sayi = sayi - (yuzler * 100);
            onlar = sayi / 10;
            Console.WriteLine("onaler: " + onlar);
            sayi = sayi - (onlar * 10);
            birler = sayi;
            Console.WriteLine("birler: " + birler);
            sayi = birler * 100 + onlar * 10 + yuzler;
            Console.WriteLine("sayinin tersi = " + sayi);

          
        

        }
        public void Selectsorted(int [] arr, int n)
        {
            int midIdx;



            for (int i = 0; i < n; i++)
            {
                midIdx = i;
                for (int j = i + 1; j < n; j++)
                {
                    if (arr[j] < arr[midIdx])

                        midIdx = j;



                }
                swap(arr[midIdx], arr[i]);
            }
            for (int i = 0; i < n; i++)
            {
                Console.WriteLine(i + 1 + "-" + arr[i]);
            }
        }
        public void swap(int x,int y)
        {
          int  temp = x;
            x = y;
            y = temp;
        }

    }
}