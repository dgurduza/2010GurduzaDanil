using System;

namespace Task05
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Введи значения длин катетов прямоугольного треугольника. Найди AC");
            string AB = Console.ReadLine();
            string BC = Console.ReadLine();
            int a = int.Parse(AB);
            int b = int.Parse(BC);
            Console.WriteLine("AC =" + Math.Sqrt((a * a) + (b * b)));
        }
    }
}
