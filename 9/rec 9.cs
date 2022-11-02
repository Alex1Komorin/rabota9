using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _9
{
    class Program
    {
        static void Main(string[] args)
        {
            string qwerty;
            do
            {
                /*
                 *  k целое чмсло
                 *  first первое число большее К
                 *  a числа которые вводятся в цикле
                 *  i счётчик
                 *  w поррядковыйф номер числа а
                */
                int k;
                k = RecursivKey();
                int first = 0;
                int a, i = 1;
                int w = 0;
                do
                {

                    a = (int)readNumber(i, k);

                    if (a > k)
                    {
                        if (first == 0)
                        {
                            first = a;
                            w = i;
                        }
                    }
                    i++;
                }
                while (a != 0);
                if (first > 0) Console.WriteLine("Порядковый номер числа {0} число {1} ", w, first);
                else Console.WriteLine("Нет чисел больше K");
                Console.WriteLine("Повторить программу? Y|N");
            }
            while (RecursivBool() != "N");

        }
        /*
         * читаем строку и проверяем на число
         */
        static private int readNumber(int i, int k)
        {
            int a;
            Console.WriteLine("Введите {0} число", i);
            bool f = int.TryParse(Console.ReadLine(), out a);
            if (f)
            {
                return a;
            }
            else
            {
                Console.WriteLine("Неверное значение");
                return readNumber(i, k);
            }
        /*
         * Читаем строку, проверяем на число
         */
        }
        static private int RecursivKey()
        {
            int k;
            Console.WriteLine("Введите целое число К");
            bool q = int.TryParse(Console.ReadLine(), out k);
            if (q && k != 0)
            {
                return k;
            }
            else
            {
                Console.WriteLine("Неверные данные");
                return RecursivKey();
            }
        }
        /*
         * Читает символ х или у
         * возращает переменную
         * иначе повторяется
         */
        static private string RecursivBool()
        {
            string a = Console.ReadLine();

            if (a == "Y" || a == "N")
            {
                return a;
            }
            else
            {
                Console.WriteLine("Невернные данные, попробуйте ещё!"); 
                return RecursivBool();
            }
        }
    }
}
