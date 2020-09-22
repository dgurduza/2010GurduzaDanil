using System;
using System.Security.Cryptography.X509Certificates;

namespace Hw3
{
    class Program
    {
        public static int Method3(int num)
        {
            int a, b, c, d;
            if (num < 9999)
            {
                if (num > 999)
                {
                    a = num / 1000;
                    b = (num - 1000 * a) / 100;
                    c = ((((num - 1000 * a) % 100) - (num % 10)) / 10);
                    d = (num - 1000 * a) % 10;
                    Console.WriteLine($"{d}{c}{b}{a}");
                }
                else if (num > 99 && num < 999)
                {
                    a = num / 100;
                    b = (num % 100) / 10;
                    c = num % 10;
                    Console.WriteLine($"{c}{b}{a}");
                }
                else if (num > 9 && num < 99)
                {
                    a = num / 10;
                    b = num % 10;
                    Console.WriteLine($"{b}{a}");
                }
                else Console.WriteLine("Cлишком маленькое значение");
            }
            else Console.WriteLine("Слишком большое значение");
            return (num);
        }
            static void Main(string[] args)
            {
                int num;
                Console.WriteLine("Введи число");
                int.TryParse(Console.ReadLine(), out num);
                Method3(num);
            }
        
    }
}
