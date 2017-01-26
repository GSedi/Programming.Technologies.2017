using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab1_Prime
{
    class Program
    {
        // создаём функцию Isprime в которой будем проверять наши числа на простоту прогоняя через for и при это используя счётчик
        static int IsPrime(int x)
        {
            int a = x;
            int с = 0;
            for (int i = 1; i <= a; i++)
            {
                if (a % i == 0)
                    с++;
            }

            if (с == 2 || a == 1) 
                return a;

            else
                return 0;
        }

        static void Main(string[] args)
        {
            /*записываем наши числа через пробел и с помощью функции Split каждое число сохраняем в ячейку нового массива arr,
              далее отправляем каждую ячейку в функцию IsPrime зарание перевидя и integer*/
            Console.WriteLine("Enter your numbers: ");

           
            string s = Console.ReadLine();

            string[] arr = s.Split();

            int y;
            int z;
            Console.WriteLine("Prime numbers are:");

            for (int i = 0; i < arr.Length; i++)
            {
                y = int.Parse(arr[i]);
                z = IsPrime(y); 
                if (z == y)
                {
                    Console.Write(y + " ");
                }
            
            }

            Console.WriteLine("\nPress any key to exit...");
            Console.ReadKey();
        }
    }
}
