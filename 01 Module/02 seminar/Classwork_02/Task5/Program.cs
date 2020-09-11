using System;

namespace Task5
{
    class Program
    {
        static void Main(string[] args)
        {
          
            int number = 0;
            int evenNumber = 0;
            Console.WriteLine("Count=" + evenNumber);
            do
            {
                System.Console.Write("Input number: ");
                int.TryParse(System.Console.ReadLine(), out number);
            }
            while (number != 0);
            Console.WriteLine("count = " + evenNumber);
        }
    }
}
