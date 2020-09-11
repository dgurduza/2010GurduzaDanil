using System;
/*
   Дисциплина: "Программирование"
   Группа:      2010ПИ/1
   Студент:     Гурдуза Даниил Михайлович
   Дата:        11.09.2020
*/
namespace Task1
{
    class Program
    {
        public static uint Method(uint code)
        {
            string report;
         report = code <= '9' && code >= '0' ? "Это цифра: " + (char)code
          : code <= 'Я' && code >= 'А' ? "Это прописная буква: " + (char)code
          : code <= 'я' && code >= 'а' ? "Это строчная буква: " + (char)code
          : "Неизвестный символ!";
          Console.WriteLine(report);
            return (code);
        }
        static void Main(string[] args)
        {
            uint code;
            string str;
            
            uint codeА= (uint)'А',
                 codeа= (uint)'а',
                 codeЯ= (uint)'Я',
                 codeя= (uint)'я',
                 code0 = (uint)'0';
            Console.WriteLine("Коды граничных символов:");
            Console.WriteLine("Код А = " + codeА + "; Код Я = " + codeЯ +
                        "; Код а = " + codeа + "; Код я = " + codeя +
                        "; Код нуля = " + code0);
            Console.Write("Введите значение code: ");
            str = Console.ReadLine();
            uint.TryParse(str, out code);

            Method(code);

        }
    }
}
