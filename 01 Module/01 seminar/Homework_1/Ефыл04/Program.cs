using System;

namespace Ефыл04
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Введите значения U и R");
            
            string U = Console.ReadLine();
            string R = Console.ReadLine();
            
            int a = int.Parse(U);
            int b = int.Parse(R);
            if ((b < 0) || (b > 0))
            {

                Console.WriteLine("I=" + (a / b));
                Console.WriteLine("P=" + ((a * a) / b));
            }Console.WriteLine("Выполнение программы невозможно");
            
        }
    }
}
