using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab2_Complex
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Press first complex number: ");
            string s = Console.ReadLine();
            string[] arr = s.Split('/');

            Console.Write("\nPress any operation: ");
            string s2 = Console.ReadLine();

            Console.Write("\nPress second complex number: ");
            string s1 = Console.ReadLine();
            string[] arr1 = s1.Split('/');
            

            Complex a = new Complex(int.Parse(arr[0]), int.Parse(arr[1]));
            Complex b = new Complex(int.Parse(arr1[0]), int.Parse(arr1[1]));
            Complex c;

            if (s2 == "+")
            {
                c = a + b;
            }else if(s2 == "-")
            {
                c = a - b;
            }else if(s2 == "*")
            {
                c = a * b;
            }
            else
            {
                c = a / b;
            }
                

            Console.Write("\nThe answer is: " + c + "\nPress any key to exit...");

            Console.ReadKey();

        }
    }
}
