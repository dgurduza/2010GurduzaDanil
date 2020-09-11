using System;
using System.ComponentModel;
using System.IO;
using System.Security.Cryptography.X509Certificates;

namespace Task1
{
    class Program
    {

        static void Main(string[] args)
        {
            ConsoleKeyInfo keyToExit;
            double a, b; 
            do
            {
                do
                {
                    Console.Write("Введите число a: ");
                } while (!double.TryParse(Console.ReadLine(), out a));

                do
                {
                    Console.Write("Введите число b: ");
                } while (!double.TryParse(Console.ReadLine(), out b) | a * b < 0);
                double geomMean = Math.Sqrt(a * b);
                Console.WriteLine("Среднее геометрическое равно: " + geomMean);
                Console.WriteLine("Для выхода нажмите Escape....");
                keyToExit = Console.ReadKey();
            } while (keyToExit.Key != ConsoleKey.Escape);
        }
    }
}
