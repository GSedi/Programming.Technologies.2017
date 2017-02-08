using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Files
{
    class Program
    {
        static void f1()
        {
            //DirectoryInfo dir = new DirectoryInfo(@"D:\test");

            for(int i = 1; i <= 7; i++)
            {
                DirectoryInfo dir = new DirectoryInfo(@"D:\test\" + i + "_newFolder");
                dir.Create();
            }
        }
        static void f2()
        {
            
            for (int i = 1; i <= 7; i++)
            {
                FileInfo fs = new FileInfo(@"D:\test\1_newFolder\3_newFOLDER\" + i + "_newFile");

                fs.Create();
                    
                
                
            }
        }

        static void Main(string[] args)
        {
            f2();
        }
    }
}
