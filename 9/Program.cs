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
            mashin(true);
           


        }
        static private  bool mashin(bool f)
        {
            int k;
            k = RecursivKey();

            int first = 0;
            for (int i = 1; i <= k; i++)
            {
                int a;

                a = (int)readNumber(i, k);

                if (a > k)
                {
                    if (first == 0) first = a;
                }

                if (i == k)
                {
                    Console.WriteLine("Первое число, большее к = {0}", first);
                }
            }
            Console.WriteLine("Повторить Y|N ?");
            if (Function(Console.ReadLine()))
            {
                return mashin(true);
            }
            else return false;
        }
        static private int readNumber(int i, int k)
        {
            int a;
            Console.WriteLine("Введите {0} число", i);
            bool f = int.TryParse(Console.ReadLine(), out a);
            if (f && a != 0)
            {
                return a;
            }
            else
            {
                Console.WriteLine("Неверное значение");
                return readNumber(i, k);
            }
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
        static private bool Function(string str)
        {
            if (str != "Y" || str != "N")
            {

                return (str == "Y") ? true : false;
            }
            else
            {
                Console.WriteLine("Неверные данные");
                return Function(str);
            }

        }
    }
}
