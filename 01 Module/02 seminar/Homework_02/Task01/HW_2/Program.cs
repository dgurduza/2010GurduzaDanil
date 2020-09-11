using System;
/*
   Дисциплина: "Программирование"
   Группа:      2010ПИ/1
   Студент:     Гурдуза Даниил Михайлович
   Дата:        11.09.2020
   Классная задача 3
*/
namespace HW_2
{
    class Program
    {
        public static int Checke(int x, int y, int z)
        {
            int a, b, c;
            a = x < y ? (z < x ? z : x) : (z > y ? y : z);
            b = x < y ? (z > y ? y : z) : (z < x ? z : x);
            c = z > y ? (z < x ? x : z) : (y > z ? y : z);
            Console.WriteLine( "{0} {1} {2}",a, b, c);
            return(x);
        }
        static void Main(string[] args)
        {
            int x = 0, y = 0, z = 0;
            int str;
            Console.WriteLine("Введите x,y,z");
            x = int.Parse(Console.ReadLine());
            y = int.Parse(Console.ReadLine());
            z = int.Parse(Console.ReadLine());

            str = Checke(x, y, z);

        }
    }
}
