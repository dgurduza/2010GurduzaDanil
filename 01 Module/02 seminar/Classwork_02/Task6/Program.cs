using System;

namespace Task6
{
    class Program
    {
        public static double S(double r)
        {
            return Math.PI * r *r;
        }
        public static double L (double r)
        {
            return 2 * Math.PI * r;
        }
        static void Main(string[] args)
        {
            double r,
                l,
                s;
            string str ;
            do
            {
                Console.WriteLine("Введи число:");
                str = Console.ReadLine();

            } while (!double.TryParse(str, out r));

            s = S(r);
            l = L(r);
            Console.WriteLine("S={0:f2}  L={1:f2}", s,l);
            Console.ReadLine();
        }
    }
}
