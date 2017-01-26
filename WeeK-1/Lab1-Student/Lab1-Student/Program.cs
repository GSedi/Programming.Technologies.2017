using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab1_Student
{
    class Program
    {
        static void Main(string[] args)
        {
            //создаём студента с данными характеристиками
            Student s = new Student("Gamidov", "Sedi", 18, 4);

            s.setFname("Gamidov");
            s.getFname();



            //выводим на консоль
            Console.Write(s);
            Console.WriteLine("\nPress any key to exit...");
            Console.ReadKey();
        }
    }
}
