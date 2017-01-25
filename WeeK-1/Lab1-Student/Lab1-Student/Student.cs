using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab1_Student
{
    class Student
    {
        //создаём характеристику студента
        private string fname;
        private string lname;
        private int age;
        private float gpa;

        public Student() { }

        
       //сохраняем элементы
        public Student(string fname, string lname, int age, float gpa)
        {
            this.fname = fname;
            this.lname = lname;
            this.age = age;
            this.gpa = gpa;
        }

        public Student(string fname)
        {
            this.fname = fname;
        }

       /* public Student(string lname)
        {
            this.lname = lname;
        
        }
        */
        public Student(int age)
        {
            this.age = age;
        }

        public Student(float gpa)
        {
            this.gpa = gpa;
        }

        public string getFname()
        {
            this.fname = "Gamidov";
            return fname;
        }

        public void setFname(string fname)
        {
            this.fname = fname;
        }

        //прописываем функцию override
        public override string ToString()
        {
            
            return string.Format("Student\nFirstName: {0}\nLastName: {1}\nAge: {2}\nGPA: {3}", fname, lname, age, gpa);
        }
    }
}
