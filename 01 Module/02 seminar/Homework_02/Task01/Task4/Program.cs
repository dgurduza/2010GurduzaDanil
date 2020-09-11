using System;
/*
   Дисциплина: "Программирование"
   Группа:      2010ПИ/1
   Студент:     Гурдуза Даниил Михайлович
   Дата:        11.09.2020
   Задание:     Сам.работа 1
*/

namespace Task4
{
    class Program
    {
        /// <summary>
        /// Метод по вычислению корня уравнения
        /// </summary>
        /// <param name="x">переменная</param>
        /// <returns></returns>
        public static int Method21(int x)
        {
            int f;
            f =  x * (x * (x * (12 * x + 9) - 3) + 2) - 4;
            Console.WriteLine(f);
            return (x);
        }
        static void Main(string[] args)
        {
            do
            {
               int x;
      
                do
                {
                    Console.WriteLine("Введи х");
                } while (!int.TryParse(Console.ReadLine(), out x));//цикл ввода и проверки х

               Method21(x);//использование метода

                Console.WriteLine("Для продолжения введите другое значение х");
                Console.WriteLine("Для выхода нажмите Escape");

            } while (Console.ReadKey(true).Key != ConsoleKey.Escape);//цикл предолжения продолжить или выйти из программы
        }
    }
}
