using System;

namespace Tasl2
{
    class Program
    {
        public static double Gen(ref double x)
        {
            double g;
            if ( x <= 0.5)
            {
                g = Math.Sin(Math.PI / 2);
                Console.WriteLine($"G={g:f3}");
            }
            else if (x > 0.5)
            {
                g = Math.Sin((Math.PI * (x - 1)) / 2);
                Console.WriteLine($"G={g:f3}");
            }
            return (x);
        }
        static void Main(string[] args)
        {
            double  x;
            Console.WriteLine("Введи число Х");
            double.TryParse(Console.ReadLine(), out x);
            Gen(ref x);

        }
    }
}

