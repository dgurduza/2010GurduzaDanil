using System;
using System.Diagnostics.CodeAnalysis;
using System.Globalization;
/*
   Дисциплина: "Программирование"
   Группа:      2010ПИ/1
   Студент:     Гурдуза Даниил Михайлович
   Дата:        11.09.2020
   Задание:     Сам.работа6
*/
namespace Task9
{
    class Program
    {
        /// <summary>
        /// Метод вычисления процентной части
        /// </summary>
        /// <param name="a">бюджет</param>
        /// <param name="b">процент на игры</param>
        /// <returns></returns>
        public static double M4(double a, double b) 
        {
            double x;

            x = a * b;
            Console.WriteLine(string.Format(new CultureInfo("en-US"), "{0:c2}", x));// подключение библиотеки System Globalization для пользования спецификатором валют
            return a;
        }
        static void Main(string[] args)
        {

            do
            {
                double a;
                double b;
                do
                {
                    Console.WriteLine("Введи сумму бюджета");
                    
                } while (!double.TryParse(Console.ReadLine(), out a));//проверка на действительность числа с помощью TryParse
                do
                {
                    Console.WriteLine("Введи процент бюджета");
                   
                } while (!double.TryParse(Console.ReadLine(), out b));
                
                M4(a, b);//вызов метода
                Console.WriteLine("Для продолжения введите другие значения");
                Console.WriteLine("Для выхода нажмите Escape");
            } while (Console.ReadKey(true).Key != ConsoleKey.Escape);//цикл предолжения продолжить или выйти из программы
        }
    }
}
