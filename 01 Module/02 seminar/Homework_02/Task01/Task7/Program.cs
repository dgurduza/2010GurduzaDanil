using System;
/*
   Дисциплина: "Программирование"
   Группа:      2010ПИ/1
   Студент:     Гурдуза Даниил Михайлович
   Дата:        11.09.2020
   Задание:     Сам.работа 4
*/
namespace Task7
{
    class Program
    {
        /// <summary>
        /// Метод вычисления цифр числа и перестановки их в обратном порядке
        /// </summary>
        /// <param name="x">четырехзначное число</param>
        public static void My(int x)
        {
            int a, b, c, d;
            a = x / 1000;
            b = (x / 100) % 10;
            c = (x / 10) % 10;
            d = x % 10;
            Console.WriteLine($"{d}{c}{b}{a}");//использование интерполяции строк
        }
        static void Main(string[] args)
        {
            do
            {
                int x;
                do
                {
                    Console.WriteLine("Введи четырехзначное число");
                    
                }while(!int.TryParse(Console.ReadLine(), out x));
                
                My(x);
                Console.WriteLine("Для продолжения введите другие значения коэфициентов");
                Console.WriteLine("Для выхода нажмите Escape");
            } while(Console.ReadKey(true).Key != ConsoleKey.Escape);//цикл предолжения продолжить или выйти из программы

        }
    }
}
