using System;
/*
   Дисциплина: "Программирование"
   Группа:      2010ПИ/1
   Студент:     Гурдуза Даниил Михайлович
   Дата:        11.09.2020
   Задание:     Ввести натуральное трехзначное число Р. Найти наибольшее целое число, которое можно получить, переставляя цифры числа Р
*/
namespace Task5
{
    class Program
    {
        /// <summary>
        /// Метод вычисления и сравнения цифр числа, выводит наибольшее число, которое можно составить из цифр
        /// </summary>
        /// <param name="number">число</param>
        /// <returns></returns>
        public static int Number1(int number )
        {
            int max,
                mid,
                min;
            int x, y, z;
            x = number / 100;
            y = (number / 10) % 10;
            z = number % 10;
            if (x>=y && x>=z)//сравнение переменных с помощью цикла If...else
            {
                max = x;
                if(y>=z)
                {
                    mid = y;
                    min = z;
                }
                else
                {
                    mid = z;
                    min = y;
                }

            }
            else if (y >= x  && y >= z)
            {
                max = y;
                if (x >= z)
                {
                    mid = x;
                    min = z;
                }
                else
                {
                    mid = z;
                    min = x;
                }

            }
            else
            {
                max = z;
                if (x >= y)
                {
                    mid = x;
                    min = y;
                }
                else
                {
                    mid = y;
                    min = x;
                }
            }


            Console.WriteLine($"{max}{mid}{min}");
            return (x);
        }
        static void Main(string[] args)
        {
            do
            {
                int x;
                do
                {
                    Console.WriteLine("Введи трехзначное число");

                } while (!(int.TryParse(Console.ReadLine(), out x) && x>100 && x<999));// исключение ошибок при вводе при помощи TryParse и некоторого условия

                Number1(x);

                Console.WriteLine("Для продолжения введите другие значения коэфициентов");
                Console.WriteLine("Для выхода нажмите Escape");

            } while  (Console.ReadKey(true).Key != ConsoleKey.Escape);//цикл предолжения продолжить или выйти из программы
        }
    }
}
