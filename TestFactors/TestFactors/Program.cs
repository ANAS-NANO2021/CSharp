using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TestFactors
{
    class Program
    {
        static void Main(string[] args)
        {
            int i = 1,n;
            Console.WriteLine("enter a number : ");
            n = Convert.ToInt32(Console.ReadLine());
           
            do
            {
                if (n % i == 0)
                    Console.WriteLine("{0}", i);
                i++;

            } while (i <= 100);
            Console.ReadKey();
        }
    }
}
