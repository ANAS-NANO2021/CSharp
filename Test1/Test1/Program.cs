using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Test1
{
    class Program

    {
        public static void number( out int [] num)
        {

            num [0] = 90;

            Console.WriteLine(num [0]);

        }
        static void Main(string[] args)
        {
            /* int age = 30;
             age = Convert.ToInt32(age);
             Console.WriteLine(age);*/
            /*          Console.WriteLine(sum);*/
            /*int result = Sum(15,13);*/
            /*  Console.WriteLine(Sum(13, 37));*/
            int [] x ;
            Console.WriteLine(x [0]);
            number( out x );
            Console.WriteLine(x [0]);


            Console.ReadKey();
        }
    }
}
