using System;
using MyLib;

namespace ex7
{
    internal class Program
    {
        static int[] alphabet = new int[0];
        static int lex = 0, length = 0;

        private static void Main()
        {
            while (true)
            {
                length = Ask.Num("Введите количество элементов (длину слова): ");
                lex = Ask.Num("Введите емкость алфавита: ");
                Console.WriteLine();

                alphabet = new int[lex];                    // инициализация алфавита
                
                for (var i = 0; i < lex; i++)
                    alphabet[i] = Ask.Num(String.Format("Введите {0} число: ", i+1));
                
                var num = Math.Pow(lex, length);            // количество комбинаций

                for (var i = 0; i < num; i++)
                    CreateWord(i);
                
                OC.Stay();
            }
        }

       static void CreateWord(int num)
        {
            var inSystem = Convert.ToString(num, lex);              // перевели в систему счисления
            const char start = '0';                                 // переменная для начала отсчета
            
            inSystem = inSystem.PadLeft(length).Replace(" ", "0");  // добавление незначащих нулей в начале

            for (var i = 0; i < length; i++)
            {
                var index = (int)inSystem[i] - (int)start;
                Console.Write(alphabet[index]);
            }

            Console.Write(", ");
        }
    }
}
