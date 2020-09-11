using System;
/*
   Дисциплина: "Программирование"
   Группа:      2010ПИ/1
   Студент:     Гурдуза Даниил Михайлович
   Дата:        11.09.2020
   Задание:     Сам.работа 5
*/
namespace Task8
{
    
    class Program
    {
        /// <summary>
        /// Метод проверки в уравнении на неравенство треугольников
        /// </summary>
        /// <param name="a">Первая сторона</param>
        /// <param name="b">Вторая сторона</param>
        /// <param name="c">Третья сторона</param>
        public static void M3(double a, double b, double c)
        {
            bool x;
            x = a < b + c && b < a + c && c < a + b;
            Console.WriteLine(x ? "Неравенство действительно" : "Неравенство не действительно");

        }

        static void Main(string[] args)
        {
            do //использование цикла для повтора работы программы
            {
                double a, b, c;
                do
                {
                    Console.WriteLine("Введи сторону а");
                } while (!double.TryParse(Console.ReadLine(), out a));
                do
                {
                    Console.WriteLine("Введи сторону b");
                } while (!double.TryParse(Console.ReadLine(), out b));
                do
                {
                    Console.WriteLine("Введи сторону c");
                } while (!double.TryParse(Console.ReadLine(), out c));//проверка вводимого значения через TryParse

                M3(a, b, c);
                Console.WriteLine("Для продолжения введите другие значения");
                Console.WriteLine("Для выхода нажмите Escape");
            } while (Console.ReadKey(true).Key != ConsoleKey.Escape);//цикл предолжения продолжить или выйти из программы

        }
    }
}
