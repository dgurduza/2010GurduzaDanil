using System;
using System.Runtime.InteropServices.ComTypes;

namespace Tasl4
{
    class Program
    {
        public static void Srav(double x, double y)
        {
            double r = 2;
            double z;
            z = Math.Atan2(x, y);
            if (z >= (-Math.PI / 2) && z <= Math.PI / 4 && x * x + y * y <= r * r)
            {
                Console.WriteLine("True");
            }
            else Console.WriteLine("False");
        }
        static void Main(string[] args)
        {
            double x, y;
            Console.WriteLine("Введи x");
            double.TryParse(Console.ReadLine(), out x);
            Console.WriteLine("Введи y");
            double.TryParse(Console.ReadLine(), out y);
            Srav(x, y);
        }
    }
}
