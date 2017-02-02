using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab2_minPrime
{
    class Program
    {
        static void minPrime()
        {
            FileStream fs = new FileStream(@"C:\Users\Администратор\Desktop\РТ\test\folder\Read.txt", FileMode.Open, FileAccess.Read);
            StreamReader sr = new StreamReader(fs);

            string s = sr.ReadLine();

            string[] arr = s.Split();

            long mini = 999999999999999;

            for (int i = 0; i < arr.Length; i++)
            {
                int t = int.Parse(arr[i]);

                if (IsPrime(t) == t)
                {
                    if (t <= mini)
                    {
                        mini = t;
                    }
                }


            }
            Write(mini);
            sr.Close();
            fs.Close();

            // Console.WriteLine("Prime MIN = " + mini);

        }

        static int IsPrime(int x)
        {
            int t = x;

            int cnt = 0;

            for (int i = 1; i <= t; i++)
            {
                if (t % i == 0)
                {
                    cnt++;
                }

            }
            if (cnt == 2 || t == 1)
            {
                return t;
            }
            else
            {
                return 0;
            }
        }
        static void Write(long x)
        {
            FileStream fs = new FileStream(@"C:\Users\Администратор\Desktop\РТ\test\folder\Write.txt", FileMode.Open, FileAccess.Write);

            StreamWriter sw = new StreamWriter(fs);

            long a = x;
            sw.WriteLine("The min prime number is: " + a);
            sw.Close();
            fs.Close();
        }
        static void Main(string[] args)
        {
            minPrime();
            Console.Write("Press any key to exit...");
            Console.ReadKey();
        }
    }
}
