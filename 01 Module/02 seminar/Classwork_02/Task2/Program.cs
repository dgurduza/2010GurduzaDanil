using System;
using System.Runtime.CompilerServices;
/*

Дисциплина: "Программирование"

Группа: БПИ2010

Студент: Гурдуза Даниил

Дата: 9.09.2020
Задача: Пользователем с клавиатуры вводятся два вещественных

числа a и b. Вычислить и вывести на экран их среднее геометрическое.

*/
namespace Task2
{
    class Program
    {
     
        static void Main(string[] args)
        {
            double a ,b;
            Console.WriteLine("Введи число А");
            a = double.Parse(Console.ReadLine());
            Console.WriteLine("Введи число B");
            b = double.Parse(Console.ReadLine());
            double result = Math.Sqrt(a * b);
            Console.WriteLine("Result:" + result);
            Console.ReadLine();
        }
    }
}
