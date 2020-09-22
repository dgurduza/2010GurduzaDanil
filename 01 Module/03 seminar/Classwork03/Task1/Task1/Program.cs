using System;
using System.Net.NetworkInformation;

namespace Task1
{
    class Program
    {
        public static double Method(int a, int b, int c)
        {
            double x, x1, d;
            d = b * b - 4 * a * c;
            x = (-b - d) / 2 * a;
            x1 = (-b + d) / 2 * a;
            Console.WriteLine($"{x},{x1}");
        }
        static void Main(string[] args)
        {
            double x, x1, d;
            int a, b, c;
            Console.WriteLine("Значения коэфициента");
            int.TryParse(Console.ReadLine(), out a);
            int.TryParse(Console.ReadLine(), out b);
            int.TryParse(Console.ReadLine(), out c);
            
      
            if ( a == b && b == c == 0)
            {
             Console.WriteLine(false)
            }else if (a=b=0)
            {

            }
        }
    }
}
