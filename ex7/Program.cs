using System;
using MyLib;

// нет проверки на повторяемость при вводе алфавита
// размещаем только цифры

namespace ex7
{
    internal class Program
    {
        static int[] alphabet = new int[0];                 // алфавит
        static int lex = 0,                                 // основание системы счисления или емкость алф
            length = 0;                                     // длина слова

        private static void Main()
        {
            while (true)
            {
                length = Ask.Num("Введите количество элементов (длину слова): ");
                lex = Ask.Num("Введите емкость алфавита: ");
                Console.WriteLine();

                alphabet = new int[lex];                    // инициализация алфавита
                
                for (long i = 0; i < lex; i++)
                    alphabet[i] = Ask.Num(String.Format("Введите {0} число: ", i+1));
                
                var num = Math.Pow(lex, length);            // количество комбинаций

                for (var i = 0; i < num; i++)
                    CreateWord(i);
                
                OC.Stay();
            }
        }

       static void CreateWord(int num)
        {
            var inSystem = FromDec(num, lex);                       // перевели в систему счисления
            const char start = '0';                                 // переменная для начала отсчета
            
            inSystem = inSystem.PadLeft(length).Replace(" ", "0");  // добавление незначащих нулей в начале

            for (var i = 0; i < length; i++)
            {
                var index = (int)inSystem[i] - (int)start;
                Console.Write(alphabet[index]);
            }

            Console.Write(" ");
        }

         static string FromDec(int num, int lex)
        {
            var result = "";                                        // результат

            for (; num > 0; num /= lex)                             // делить на основание системы
            {
                var x = num % lex;                                  // остаток от деления
                result = (char)(x < 0 || x > 9 ? x + 'A' - 10 : x + '0') + result;
            }

            return result;
        }

    }
}
