using System;

namespace ArrayTest
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");

            char[] names = { 'A', 'N', 'A', 'S' };
            string name = new string(names);
            Console.WriteLine("ur  name is : " + name);
            //for (int i = 0; i <4; i++)
            //{
            //    Console.WriteLine( names[i]);
            //}
            string [] MyName = { "ANAS","HANAN,KAREEM ,ROOH" };
            //char[] Name;
            int i = 0;
            foreach(string MyFuturFamily in MyName)
            {
                Console.WriteLine("MyFuturFamily : "+i+"-"+ MyFuturFamily);
                i++;
            }
            //            Console.WriteLine(MyName);
            //Console.WriteLine(Name);
        }
    }
}
