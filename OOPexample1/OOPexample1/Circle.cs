using System;
namespace OOPexample1
{
    internal class Circle
    {

        private double pi ;
        private int radius;


        public double Pi { get => pi; set => pi = value; }
        public int Radius { get => radius; set => radius = value; }

        public void Area()
        {
            Console.WriteLine("Area : " + radius * radius * pi);
        }
    }

    }
