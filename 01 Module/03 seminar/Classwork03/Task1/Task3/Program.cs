using System;
using System.Net.Http.Headers;

namespace Task3
{
    class Program
    {
        static void Main(string[] args)
        {
            int a;
            Console.WriteLine("Введи оценку");
            int.TryParse(Console.ReadLine(), out a);

            switch (a)
            {
                case 1:
                case 2:
                case 3:
                    Console.WriteLine("Неудовлетворительно");
                        break;
                case 4:
                case 5:
                case 6:
                    Console.WriteLine("удовлетворительно");
                    break;
                case 7:
                case 8:
                    Console.WriteLine("хорошо");
                        break;
                
                case 9:
                case 10:
                    Console.WriteLine("отлично");
                        break;
                
               
                

            }

        }
    }
}
