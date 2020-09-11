using System;
/*
   Дисциплина: "Программирование"
   Группа:      2010ПИ/1
   Студент:     Гурдуза Даниил Михайлович
   Дата:        11.09.2020
   Задание:     Сам.работа 3
*/
namespace Task6
{
    class Program
    {
        /// <summary>
        /// Метод находит корни квадратного уравнения
        /// </summary>
        /// <param name="a">коэфициент</param>
        /// <param name="b">коэфициент</param>
        /// <param name="c">коэфициент</param>
        /// <returns></returns>
        public static int DIsc(int a, int b, int c)
        {
            double d;
            double x1, x2;
            d =Math.Sqrt( Math.Pow(b, 2) - 4 * a * c); 
            x1 = (-b - d) / (2 * a);
            x2 = (-b + d) / (2 * a);
            Console.WriteLine(d>=0?$"Корни {x1}, {x2}": "Корней нет");//использование тернарной операции
            return (a);
        }
        static void Main(string[] args)
        {
            do
            {
                int a,
                    b,
                    c;
                do
                {
                    Console.WriteLine("Введи a");
                } while (!int.TryParse(Console.ReadLine(), out a));
                do
                {
                    Console.WriteLine("Введи b");
                } while (!int.TryParse(Console.ReadLine(), out b));
                do
                {
                    Console.WriteLine("Введи c");
                } while (!int.TryParse(Console.ReadLine(), out c));

                DIsc(a,b,c);
                
                Console.WriteLine("Для продолжения введите другие значения коэфициентов");
                Console.WriteLine("Для выхода нажмите Escape");

            } while (Console.ReadKey(true).Key != ConsoleKey.Escape);//цикл предолжения продолжить или выйти из программы 
        }
    }
}
