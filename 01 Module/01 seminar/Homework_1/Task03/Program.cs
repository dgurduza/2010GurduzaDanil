
using System;

namespace Task03
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Напишите число Code!");
            string code = Console.ReadLine();
            int n = int.Parse(code);
            if ((n > 32) && (n < 127))
            {
                Console.WriteLine((char)n);
                Console.WriteLine("Программа завершена");
            } else 
                Console.WriteLine("Задача не выполнена");
        }
    }
}
