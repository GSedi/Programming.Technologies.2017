﻿using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab2_Recurs
{
    class Program
    {
       
        static void f1(string path, int depth)
        {
            DirectoryInfo dir = new DirectoryInfo(path);
            FileInfo[] files = dir.GetFiles();
            DirectoryInfo[] dirs = dir.GetDirectories();

            foreach (FileInfo f in files)
            {
                for (int i = 0; i < depth; i++) Console.Write(" ");
                Console.WriteLine(f.Name);
            }

            foreach (DirectoryInfo d in dirs)
            {
                for (int i = 0; i < depth; i++) Console.Write(" ");
                Console.WriteLine(d.Name);
                f1(d.FullName, depth + 5);
            }

        }
        static void Stack(string path) 
        {
            Stack<string> directory = new Stack<string>(); 
            directory.Push(path);
            
            while (directory.Count > 0) 
            {
                DirectoryInfo dir = new DirectoryInfo(directory.Pop()); 
                
                DirectoryInfo[] dirs = dir.GetDirectories(); 
                FileInfo[] files = dir.GetFiles(); 



                Console.WriteLine(dir.Name); 
               
               foreach (FileInfo file in files) 
                {
                  
                    Console.WriteLine("        " + file.Name);
                   
                }
                
                foreach (DirectoryInfo dar in dirs)
                {
                    Console.WriteLine("    " + dar);
                    directory.Push(dar.FullName); 
                }

              
                
            }
        }

            static void Main(string[] args)
        {
            Stack(@"D:\test");
            //f1(@"D:\test", 0);
            
            Console.ReadKey();
        }

        
    }

}
