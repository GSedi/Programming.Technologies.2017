using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FarManager
{
    class Program
    {
        static void showInfo(DirectoryInfo dir, int cursor)
        {
            Console.Clear();
            FileSystemInfo[] infos = dir.GetFileSystemInfos();
            for (int i = 0; i < infos.Length; i++)
            {
                
                if(i == cursor)
                {
                    Console.BackgroundColor = ConsoleColor.White;
                } else {
                    Console.BackgroundColor = ConsoleColor.Black;
                }
                
                //Console.BackgroundColor = (i == cursor) ? ConsoleColor.Blue : ConsoleColor.Black;
                
                if (infos[i].GetType() == typeof(DirectoryInfo))
                {
                    Console.ForegroundColor = ConsoleColor.Green;
                } else {
                    Console.ForegroundColor = ConsoleColor.Cyan;
                }
                
                //Console.ForegroundColor = (infos[i].GetType() == typeof(DirectoryInfo)) ? ConsoleColor.Yellow : ConsoleColor.Magenta;

                Console.WriteLine(infos[i].Name);
            }

        }
        static void f(string path)
        {
            Console.Clear();
            FileStream fs = new FileStream(path, FileMode.Open, FileAccess.ReadWrite);
            StreamReader sr = new StreamReader(fs);
            StreamWriter sw = new StreamWriter(fs);

            string s = sr.ReadToEnd();
            Console.WriteLine(s);

           // string n = Console.ReadLine();
            //Console.WriteLine(n);
            

           
            sr.Close();
            fs.Close();

            Console.ReadKey();
        }
            static void Main(string[] args)
        {
            Console.CursorVisible = false;
            int cursor = 0;
            DirectoryInfo dir = new DirectoryInfo(@"D:\test");
            bool a = true;
            while (a)
            {
                showInfo(dir, cursor);
                ConsoleKeyInfo btn = Console.ReadKey();
                switch (btn.Key)
                {
                    case ConsoleKey.UpArrow:
                        if (cursor > 0) cursor--;
                        break;
                    case ConsoleKey.DownArrow:
                        if (cursor < dir.GetFileSystemInfos().Length - 1) cursor++;
                        break;
                    case ConsoleKey.Enter:
                        FileSystemInfo fs = dir.GetFileSystemInfos()[cursor];
                        if (fs.GetType() == typeof(DirectoryInfo))
                        {
                            dir = new DirectoryInfo(fs.FullName);
                        }
                        else 
                        {

                            f(fs.FullName);

                            //Process.Start(fs.FullName);
                        }
                        break;
                    case ConsoleKey.Backspace:
                        dir = dir.Parent;
                        break;
                   case ConsoleKey.Escape:

                        a = false;    

                        break;

                }

            }
        }
    }
}

