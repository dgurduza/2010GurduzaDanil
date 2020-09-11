using System;

namespace Classwork_02
{
    class Program
    {
        static void Main(string[] args)
        {
            Random random = new Random();
            int number = random.Next(96 , 123);
            
            Console.WriteLine((char)number);
        }
    }
}
