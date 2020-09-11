using System;
using System.Diagnostics.CodeAnalysis;
using System.Globalization;
/*
   Дисциплина: "Программирование"
   Группа:      2010ПИ/1
   Студент:     Гурдуза Даниил Михайлович
   Дата:        11.09.2020
   Задание:     Сам.работа 6
*/
namespace Task9
{
    class Program
    {
        /// <summary>
        /// Метод вычисления процентной части
        /// </summary>
        /// <param name="a">бюджет</param>
        /// <param name="b">процент</param>
        /// <returns></returns>
        public static double M4(double a, int b) 
        {
            double x,c;
            c= (double)b;
            x = a * c;
            Console.WriteLine(string.Format(new CultureInfo("en-US"), "{0:c2}", x));// подключение библиотеки System Globalization для пользования спецификатором валют
            return a;
        }
        static void Main(string[] args)
        {

            do
            {
                double a;
                int b;
                do
                {
                    Console.WriteLine("Введи сумму бюджета");
                    
                } while (!double.TryParse(Console.ReadLine(), out a));//проверка на действительность числа с помощью TryParse
                do
                {
                    Console.WriteLine("Введи процент бюджета");
                   
                } while (!int.TryParse(Console.ReadLine(), out b));
                
                M4(a, b);//вызов метода
                Console.WriteLine("Для продолжения введите другие значения");
                Console.WriteLine("Для выхода нажмите Escape");
            } while (Console.ReadKey(true).Key != ConsoleKey.Escape);//цикл предолжения продолжить или выйти из программы
        }
    }
}
