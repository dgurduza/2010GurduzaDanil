using System;
/*
   Дисциплина: "Программирование"
   Группа:      2010ПИ/1
   Студент:     Гурдуза Даниил Михайлович
   Дата:        11.09.2020
   Классная задача 6
*/
namespace Task3
{
    class Program
    {
        static void Main(string[] args)
        {
            const double R = 10;
            double x, y;
            
            Console.Write("x = ");
            double.TryParse(Console.ReadLine(), out x);
            
            Console.Write("y = ");
            double.TryParse(Console.ReadLine(), out y);
            string report = "Точка ";
            report += x * x + y * y > R * R ? "Вне круга!" : "Внутри круга!";//использование тернарной операции
           
            Console.WriteLine(report);
            Console.WriteLine("Для выхода из программы нажмите ENTER.");
            Console.ReadLine();

        }
    }
}
