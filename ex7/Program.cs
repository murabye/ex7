using System;
using MyLib;

namespace ex7
{
    internal class Program
    {
        private static void Main()
        {
            while (true)
            {
                int length = Ask.Num("Введите количество элементов (длину слова): "),
                lex = Ask.Num("Введите емкость алфавита: ");

                Console.WriteLine();

                var alphabet = new int[lex];
                
                for (var i = 0; i < lex; i++)
                    alphabet[i] = Ask.Num(String.Format("Введите {0} число: ", i+1));
                
                var num = Math.Pow(lex, length);            // количество комбинаций

                for (var i = 0; i < num; i++)
                {
                    
                }

                // перевод в систему счисления
                Convert.ToString(1, 3);

                OC.Stay();
            }
        }
    }
}
