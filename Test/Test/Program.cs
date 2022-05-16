
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Test
{
    class Program
    {
        static void Main(string[] args)
        {
            String  Rows;
            int k = 0;
            Console.WriteLine("Enter the number of rows: ");
            Rows = Console.ReadLine();
            int rows = Convert.ToInt32(Rows);
            for (int i = 1; i <= rows; ++i,k=0)
            {
                for (int j = 1; j <=rows- i; ++j)
                {
                    Console.Write("  ");
                }
                while( k != 2 * i - 1)
                {
                    Console.Write("* ");
                    k++;
                }
                Console.Write("\n");
            }
            Console.ReadKey();
        }
    }
}
