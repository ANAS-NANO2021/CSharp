using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Names_ARR
{
    class Names
    {
      
        private string[] arrayName;

        public Names(string[] arrayName)
        {
            this.arrayName = arrayName;
        }

     
        public String ArrName(string sepratore)
        {
            string name = " " ;
            foreach(var Names in arrayName)
            {
                name += Names + sepratore;
            }
            return name;
          
        }
        public void PrintArrNames(string sepratore)
        {
            Console.WriteLine(ArrName( sepratore));
        }
    }
}
