using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Runtime.Serialization.Formatters.Binary;
using System.Text;
using System.Threading.Tasks;


namespace Serialization
{
    class Program
    {
        static void Main(string[] args)
        {
            f1();
            //f2();
            Console.ReadKey();
        }

        static void f2()
        {
            BinaryFormatter bf = new BinaryFormatter();
            FileStream fs = new FileStream(@"D:/test/1_newFolder/1_newFOLDER/1_newFile", FileMode.Open, FileAccess.Read);

            try
            {
                Student s = bf.Deserialize(fs) as Student;
                Console.Write(s);

                Console.ReadKey();
            }
            catch
            {
                Console.Write("deserialize error");
            }
            finally
            {
                fs.Close();
            }
        }

        static void f1()
        {
            BinaryFormatter bf = new BinaryFormatter();
            FileStream fs = new FileStream(@"D:/test/1_newFolder/1_newFOLDER/1_newFile", FileMode.OpenOrCreate, FileAccess.ReadWrite);

            Student s = new Student();
            s.setInfo();

            try
            {
                bf.Serialize(fs, s);
            }
            catch
            {
                Console.Write("serialize error");
            }
            finally
            {
                fs.Close();
            }
        }
    }
}
