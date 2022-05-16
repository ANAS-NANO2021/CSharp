using System;

namespace ForExample
{
    class Program
    {
        static void Main(string[] args)
        {
            int i, n, sum = 0;
            Console.WriteLine("Hello World! I wanna show u for using");
            Console.WriteLine("How much number do u want? ");

            n = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("u entered  : " + n+  " numbers");
            for (i = 0; i <= n; i++)
            {
                if (i % 2 == 0)
                {
                  sum += i;
                    Console.WriteLine("Sum = "+sum);
                }
                

                else {
                    sum += i;
                    Console.WriteLine("Sum = " + sum);

                }
            }

            sum = ++sum;
            Console.WriteLine("Sum = " + sum);
            sum = sum++;

            Console.WriteLine("Sum = " + sum);

            sum = --sum;
            Console.WriteLine("Sum = " + sum);
            sum = +2;
            switch (sum) {


                case 78:
                    Console.WriteLine(sum + 1);
                    break;

                    


            }


        }
    }
}
