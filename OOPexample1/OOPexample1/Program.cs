using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOPexample1
{
    class Program
    {
        static void Main(string[] args)
        {
            Circle circle = new Circle();
            circle.Pi = 3.14;
            circle.Radius = 51;
            circle.Area();
            Console.ReadLine();
        }
    }
}
