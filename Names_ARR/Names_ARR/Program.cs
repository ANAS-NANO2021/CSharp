using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Names_ARR
{
    class Program
    {
        static void Main(string[] args)
        {
            String[] ArrayName = { "ANAS", "HANAN ", "ROOH","KAREEM" };
          Names names = new Names(ArrayName);
            names.PrintArrNames(" ; \n");

            Console.ReadKey();
           
        }
    }
}
