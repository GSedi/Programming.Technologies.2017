using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication1
{
    class Program
    {
        /// <summary>
        /// Функция проверки на простоту число
        /// </summary>
        /// <param name="x">искомое число в виде строки</param>
        /// <returns></returns>
        static bool IsPrime(string x)
        {
            //получаем числовое значение числа
            int a = int.Parse(x);

            int cnt = 0;
            //находим количество делителей
            for (int i = 1; i <= a; ++i)
            {
                if (a % i == 0)
                {
                    cnt++;
                }
            }

            if (cnt == 2) return true;

            return false;
        }

        static void Main(string[] args)
        {
            string s = Console.ReadLine();
            string[] arr = s.Split();

            //Console.WriteLine(args.Length);
            for (int i = 0; i < s.Length; ++i)
            {
                if (IsPrime(arr[i])==true)
                {
                    Console.WriteLine(arr[i]);
                }
            }
        }
    }
}
