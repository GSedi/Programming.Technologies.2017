using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab2_maxANDmin
{
    class Program
    {
        static void MaxMin()
        {
            FileStream fs = new FileStream(@"C:\Users\Администратор\Desktop\РТ\test\folder\Read.txt", FileMode.Open, FileAccess.Read);

            StreamReader sr = new StreamReader(fs);

            string s = sr.ReadLine();

            string[] arr = s.Split();

            int maxi = 0;
            long mini = 999999999999999999;


            for (int i = 0; i < arr.Length; i++)
            {
                int t = int.Parse(arr[i]);

                if (t >= maxi)
                {
                    maxi = t;
                }

                if (t <= mini)
                {
                    mini = t;
                }

            }

            Console.WriteLine("MAX = " + maxi);
            Console.WriteLine("MIN = " + mini);

            sr.Close();
            fs.Close();


        }
        static void Main(string[] args)
        {
            MaxMin();
            Console.WriteLine("Press any key to exit...");
            Console.ReadKey();
        }
    }
}

