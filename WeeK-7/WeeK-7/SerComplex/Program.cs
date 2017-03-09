using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Runtime.Serialization.Formatters.Binary;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Serialization;

namespace SerComplex
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
            }
            else if (s2 == "-")
            {
                c = a - b;
            }
            else if (s2 == "*")
            {
                c = a * b;
            }
            else
            {
                c = a / b;
            }

            Console.Write("\nThe answer is: " + c + "\n\nPress any key to exit...");

            Console.WriteLine("\n\nPress F2 to Save:");
            Console.WriteLine("Press F3 to Resume last action:");
            ConsoleKeyInfo btn = Console.ReadKey();
            switch (btn.Key)
            {
                case ConsoleKey.F2:
                    save(a,b, c);
                    //XmlSave(c);


                    break;
                case ConsoleKey.F3:
                    deser(a, b, c);
                    break;
            }
           
            

         
           // Console.ReadKey();

           

       

        }
        
        static void save(Complex a, Complex b, Complex c)
        {

           /* Complex a = new Complex(12, 13);
            Complex b = new Complex(15, 14);
            Complex c = a+b;
            */
            FileStream fa = new FileStream("a.ser", FileMode.OpenOrCreate, FileAccess.ReadWrite);
            FileStream fb = new FileStream("b.ser", FileMode.OpenOrCreate, FileAccess.ReadWrite);
            FileStream fc = new FileStream("c.ser", FileMode.OpenOrCreate, FileAccess.ReadWrite);
            BinaryFormatter bf = new BinaryFormatter();

          //  Complex c = new Complex();
            try
            {
                bf.Serialize(fc, c);
                bf.Serialize(fa, a);
                bf.Serialize(fb, b);


            }
            catch
            {
                Console.Write("serialize error");
            }
            finally
            {
               fc.Close();
                fa.Close();
                fb.Close();

            }

        }

        static void deser(Complex a, Complex b, Complex c )
        {

            Console.Clear();
          FileStream fc = new FileStream("c.ser", FileMode.OpenOrCreate, FileAccess.ReadWrite);
            FileStream fa = new FileStream("a.ser", FileMode.OpenOrCreate, FileAccess.ReadWrite);
            FileStream fb = new FileStream("b.ser", FileMode.OpenOrCreate, FileAccess.ReadWrite);
            BinaryFormatter bf = new BinaryFormatter();



            try
            {
                 a = bf.Deserialize(fa) as Complex;
                Console.WriteLine("First complex number is: " + a);
                
                 b = bf.Deserialize(fb) as Complex;
                Console.WriteLine("\nSecond complex number is: " + b);

                c = bf.Deserialize(fc) as Complex;
                Console.WriteLine("\nThe answer is: " + c);
                Console.Write("\nPress any key to exit...");
                Console.ReadKey();
            }
            catch
            {
                Console.Write("deserialize error");
            }
            finally
            {

                fc.Close();
                fa.Close();
                fb.Close();
            }
        }

        

        
    }
}
