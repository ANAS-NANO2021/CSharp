using System;

namespace anonymousTest
{





    using System;
    class Go
    {
        private delegate void _Toweb(string ur1);
        private static void Run(string ur1)
        {
            System.Diagnostics.Process.Start(ur1);
        }
        public static void Toweb(string ur1)
        {
            _Toweb toweb = Run;
            toweb(ur1);
        }
    }

    /*class useIt {
        public string sum(int x, int y)
        {
            return "count this opration";
        }
        public string sub(int x,int y)
        {
            return "subtract this opertaion";

        }
    }*/
    class Program
    {
        //  delegate void Temsilci(int s1, double s22);
        //  delegate string oprations(int x, int y);
        static void Main()
        {
            Go.Toweb("https://www.google.com/search?q=Kuveyt+T%C3%BCrk+Bankas%C4%B1&sxsrf=APq-WBs5GrGtlKI66wiNdkMpng58qMRVVA%3A1647208405897&ei=1WcuYvWuNtaIxc8P4YiPuAo&oq=kuwait+turk&gs_lcp=Cgdnd3Mtd2l6EAEYAjIHCAAQRxCwAzIHCAAQRxCwAzIHCAAQRxCwAzIHCAAQRxCwAzIHCAAQRxCwAzIHCAAQRxCwAzIHCAAQRxCwAzIHCAAQRxCwAzIHCAAQsAMQQzISCC4QxwEQ0QMQyAMQsAMQQxgBMhIILhDHARCjAhDIAxCwAxBDGAFKBAhBGABKBAhGGABQAFgAYPZSaAZwAXgAgAEAiAEAkgEAmAEAyAELwAEB2gEECAEYCA&sclient=gws-wiz");

            /*  useIt u = new useIt();
              oprations op1 = new oprations(u.sum);
              oprations op2 = u.sub;*//*
              int x, y;
              char oprat;
              x = Convert.ToInt32(Console.ReadLine());
              y = Convert.ToInt32(Console.ReadLine());
              *//*int sum = x + y;
              int sub = x - y;*//*

             oprat = Convert.ToChar(Console.ReadLine());
             *//* Console.WriteLine(op1(x, y));

              Console.WriteLine(op2(x, y));*//*
              switch (oprat)
                  {
                      case ('+'):
                          Console.WriteLine( x + "+" + y + "=" + x + y);
                          break;



              }
          }
              */
        }


    }
}
