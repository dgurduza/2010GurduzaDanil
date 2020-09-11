using System;
/*
   Дисциплина: "Программирование"
   Группа:      2010ПИ/1
   Студент:     Гурдуза Даниил Михайлович
   Дата:        11.09.2020
   Классная задача 5
*/
namespace Task2
{
    class Program
    {
        /// <summary>
        /// Метод по вычислению цифр
        /// </summary>
        /// <param name="number">число</param>
        /// <param name="first">первая цифра</param>
        /// <param name="second">вторая</param>
        /// <param name="third">третья</param>
        public static void Numerals(uint number, out uint first, out uint second, out uint third)
        {
            first = number / 100;            
            uint temp = number - first * 100;
            second = temp / 10;           
            third = temp - second * 10;        
        }
        static void Main()
        {
            uint numb ;
            do
            {
                Console.Write("Введите целое от 100 до 999: ");

            } while (!uint.TryParse(Console.ReadLine(), out numb) || numb < 100 || numb > 999);// Проверка введенных с консоли значений

            uint a, b, c;
            Numerals(numb, out a, out b, out c);
            Console.WriteLine(a);//Вывод цифр числа на экран
            Console.WriteLine(b);
            Console.WriteLine(c);
        }
    }
}
