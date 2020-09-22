using System;

namespace Task01
{
    class Program
    {
        public static double Gen(ref double x,ref double y)
        {
            double g;
            if (x < y && x > 0)
            {
                g = x + Math.Sin(y);
            }
            else if (x > y && x < 0)
            {
                g = y - Math.Cos(x);
            }
            else g = 0.5 * x * y;
            Console.WriteLine($"G={g:f3}");
            return (g);
        }
        static void Main(string[] args)
        {
            double g, x, y;
            Console.WriteLine("Введи число Х");
            double.TryParse(Console.ReadLine(), out x);
            Console.WriteLine("Введи число Y");
            double.TryParse(Console.ReadLine(), out y);
            Gen(ref x, ref y);
            
        }
    }
}
