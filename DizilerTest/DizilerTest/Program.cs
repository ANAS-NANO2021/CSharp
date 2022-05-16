using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DizilerTest
{
    class Program
    {
       /* public static void Toplam()
        {*/

            
         /*   int [] Numbers = new int[5];
            int [] sum = new int [5];
            Console.WriteLine("Enter the numbers tht u want : ");
            for (int i = 1; i < 5; i++)
            {
                Console.WriteLine(i + ".number : ");
                Numbers[i] = Convert.ToInt32(Console.ReadLine());



               

            }
           
            for (int j = 1; j < 5; j++)
            {
              
                sum[j]  = sum[j] +  Numbers[j];
                Console.WriteLine("sum = " + sum[j]);

            }

            foreach (int i in Numbers)
            {
                Console.WriteLine("numbers : " + i);
              

            }
            Console.WriteLine("sum = " + sum);
*/

       // }
        static void Main(string[] args)
        {
           
           
            Random rnd = new Random();
            int top = 0;
            double ort = 0.0;
            int[] sayilar = new int[100];

            for (int i = 0; i < sayilar.Length-1; i++)
            {
                sayilar[i] = rnd.Next(1, 100);

            }
            for (int i = 0; i < sayilar.Length - 1; i++)
            {
                top += sayilar[i];


            }
      

            foreach (int sayi in sayilar)
            {
            Console.WriteLine(sayi);
            }
            ort = top / sayilar.Length;
                
            /* int n;
             n = Convert.ToInt32(Console.ReadLine());
             Random rndm = new Random();
             int[] nums = new int[n];
             int sum = 0;
             Console.WriteLine("enter the numbers tht u want : ");
             for (int i = 0; i < n; i++)
             {
                  nums[i] = Convert.ToInt32(Console.ReadLine());
                // nums [i]  = rndm.Next(0, 20);
             }
             Console.Write("Before : " +
                 "" +
                 "" +
                 "___________________________");


             for (int i = nums.Length; i < n; i--)
             {
                 Console.WriteLine(i + 1 + "-Number = " + nums[i]);
             }
             for (int i = 0; i < n; i++)
             {
                 for (int j = 0; j < n; j++)
                 {
                     if (nums[j]> nums[i])
                     {
                         int temp = nums[i];
                         nums[i] = nums[j];
                         nums[j] = temp;
                     }

                 }
             }
             foreach(int numbers  in nums)
             {
                 Console.WriteLine("Numbers : " + numbers);
             }
             for (int i = 0; i < 0; i++)
             {

                 Console.WriteLine(i + 1 + "-Number = " + nums[i]);
             }

             Console.WriteLine("Sum = " + sum);
             Console.ReadKey();*/


            /*  Random rnd = new Random();
          char[] dizi = new char[20];



                  for (int k = 0; k < 20; k++)
                  {

                      dizi[k] = (char) rnd.Next(20,126); 
                      Console.WriteLine(dizi[k]);
                  }*/


            int sum = 0,number;
            bool found;
            int[,] nums = new int[3, 3];
            
            for (int k = 0; k < 3; k++)
            {

                for (int n = 0; n < 3; n++)
                {
                    Console.Write("[" + k + "]" + "[" + n + "] = ");
                    nums[k, n] = Convert.ToInt32(Console.ReadLine());

                }

            }
            
           
            Console.Write("__________________________________" +
                "" +
                "\n");
            for (int k = 0; k < 3; k++)
            {

                for (int n = 0; n < 3; n++)
                {
                    sum += nums[k, n];
                    Console.Write(nums[k, n] + "\t");


                }
                Console.Write("\n");
            }
            Console.WriteLine("enter the number tht u wanna find it: ");
            number = Convert.ToInt32(Console.ReadLine());
            for (int k = 0; k < 3; k++)
            {

                for (int n = 0; n < 3; n++)
                {
                  
                    if (nums[k, n] == number)
                    {
                        Console.WriteLine(found = true);
                    }
                }
            }
                /*   Console.WriteLine("_____________________________");

                   for (int k = 0; k < 3; k++)
                   {

                       for (int n = 3; n > 0 ; n--)
                       {

                           Console.Write(nums[k, n] + "\t");
                       }
                       Console.Write("\n");
                   }*/

                Console.WriteLine("Sum = " + sum);
            sum = 0;
            Console.WriteLine();


            /*  int[,] dizi = new int[5, 2];
              for (int i = 0; i < 5; i++)
              {
                  for (int j = 0; j < 2; j++)
                  {
                      Console.Write("[" + i + "]" + "[" + j + "] = ");
                      dizi[i, j] = Convert.ToInt32(Console.ReadLine());
                  }
              }
              Console.WriteLine("\n");
              for (int i = 0; i < 5; i++)
              {
                  for (int j = 0; j < 2; j++)
                  {
                      Console.Write(dizi[i, j] + "\t");
                  }
                  Console.WriteLine("");
              }*/
            Console.ReadKey();


        }
    }
}
