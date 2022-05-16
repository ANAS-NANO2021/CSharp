using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OopTest1
{
    class Program
    {
        static void Main(string[] args)
        {
            NyMethods mthds = new NyMethods();
            int n;
            Console.Write("eneter a number : ");
            n = Convert.ToInt32(Console.ReadLine());
            int[] arr = new int [n];
            for (int i = 0; i < n; i++)
            {
                Console.WriteLine(i + 1 + "- number : ");
                arr[i] = Convert.ToInt32(Console.ReadLine());
            }
            mthds.Selectsorted(arr, n);
           
            mthds.Test(674);

            Console.ReadKey();
           
        }
    }
}
