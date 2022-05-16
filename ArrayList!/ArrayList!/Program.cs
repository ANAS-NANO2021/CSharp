using System;
using System.Collections;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ArrayList1
{
    class Program
    {
        static void Main(string[] args)
        {
            ArrayList arrlist = new ArrayList();
            arrlist.Add(12);
            arrlist.Add(15);
            arrlist.Add(1, "Anas");
            arrlist.Add("Hi Anas ");
            arrlist.Remove(1);
            arrlist.Contains(15);
             
            foreach(var arr in arrlist)
           
                Console.WriteLine("Array = {" + arr + "}");




            Console.ReadLine();
        }
    }
}
