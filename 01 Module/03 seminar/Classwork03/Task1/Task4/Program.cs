﻿using System;

namespace Task4
{
    class Program
    {
        static double f(double x)
        {
            return x * x;
        }

        static double calc(double A, double delta)
        {
            double S = 0;
            for (double i = 0; i <= A; i += delta)
                S += delta * (f(i) + f(i + delta)/2);
            return S;
        }

        static void Main(string[] args)
        {
            do
            {
                double A, delta;
                if (!double.TryParse(Console.ReadLine().Replace('.', ','), out A))
                {
                    Console.WriteLine("Неверный ввод");
                    continue;
                }

                if (!double.TryParse(Console.ReadLine().Replace('.', ','), out delta))
                {
                    Console.WriteLine("Неверный ввод");
                    continue;
                }

                Console.WriteLine(calc(A, delta));
            } while (Console.ReadKey().Key != ConsoleKey.Escape);
        }
    }
}