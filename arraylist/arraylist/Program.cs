using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace arraylist
{
    class Program
    {
        static void Main(string[] args)
        {
            Stack stck = new Stack();
            stck.Push("Anas");
            stck.Push(121);
            stck.Push(12);
            stck.Push(13.12);
         
            foreach (var stck1 in stck)
                Console.WriteLine(stck1);
            Console.ReadKey();

        }
    }
}
