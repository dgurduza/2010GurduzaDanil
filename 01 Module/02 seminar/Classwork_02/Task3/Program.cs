using System;

namespace Task3
{
    class Program
    {
        public static int CalculateBine(uint n)
        {
         double b = (1 + Math.Sqrt(5)) / 2;
         double u = (Math.Pow(b, n) - Math.Pow(-b, -n)) / (2 * b - 1);
         return (int)(u + 0.5);
        }
        static void Main(string[] args)
        {
           uint n;
           int res;

            do
            {

                Console.WriteLine("Введи номер члена ряда:");

            } while (!uint.TryParse(Console.ReadLine(), out n));
               
              res = CalculateBine(n);
            Console.WriteLine(" Число Финобачи: " + res);
            Console.WriteLine("Для выхода нажмите Enter");
            Console.ReadLine();
        }
    }
}
