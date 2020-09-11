using System;
using System.Data;
/*
   Дисциплина: "Программирование"
   Группа:      2010ПИ/1
   Студент:     Гурдуза Даниил Михайлович
   Дата:        11.09.2020
   Задание:     Сам. работа 7
*/
namespace Task10
{
    class Program
    {
        /// <summary>
        /// Метод выделения целой и дробной частей
        /// </summary>
        /// <param name="дробное число"></param>
        public static void Drob(double y)
        {
            uint x = (uint)y;
            double r = y - x;
            Console.WriteLine($"Дробная часть:{r:f3},Целая часть:{x}");
        }
        /// <summary>
        /// Метод возведения в квадрат и нахождения корня
        /// </summary>
        /// <param name="y"></param>
        public static void Cor(double y)
        {
            double t= Math.Pow(y, 2);
            if (y > 0)
            {
                double k = Math.Sqrt(y);
                Console.WriteLine($"Корень числа равен:{k:f3}");
            }
            Console.WriteLine($"Квадрат числа:{t:f3}");
        }

        static void Main(string[] args)
        {
            double a;
            do
            {
                do
                {
                    Console.WriteLine("Введи дробное число");

                } while (!double.TryParse(Console.ReadLine(), out a));

                Drob(a);//использование первого цикла
                Cor(a);//использование второго цикла
               
                Console.WriteLine("Для продолжения введите другие значения");
                Console.WriteLine("Для выхода нажмите Escape");

            } while (Console.ReadKey(true).Key != ConsoleKey.Escape);//цикл предолжения продолжить или выйти из программы
        }
    }
}
