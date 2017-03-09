using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Runtime.Serialization.Formatters.Binary;
using System.Text;
using System.Threading.Tasks;

namespace SerComplex
{
    [Serializable]
   public class Complex
    {

        private int x, y;

        public Complex() { }

        public Complex(int x, int y)
        {
            this.x = x;
            this.y = y;

        }

        public int X
        {
            get { return x; }

            set
            {
                x = value;
            }
        }


        public int Y
        {
            get { return y; }
            set
            {
                y = value;
            }
        }

             public static Complex operator +(Complex a, Complex b)
        {
            Complex c = new Complex();
            c.X = a.X * b.Y + b.X * a.Y;
            c.Y = a.Y * b.Y;
            
           
            return c;
        }
        public static Complex operator -(Complex a, Complex b)
        {
            Complex c = new Complex();
            c.X = a.X * b.Y - b.X * a.Y;
            c.Y = a.Y * b.Y;
             
            return c;
        }
        public static Complex operator *(Complex a, Complex b)
        {
            Complex c = new Complex();
            c.X = a.X * b.X;
            c.Y = a.Y * b.Y;
             
            return c;
        }
        public static Complex operator /(Complex a, Complex b)
        {
            Complex c = new Complex();
            c.X = a.X * b.Y;
            c.Y = a.Y * b.X;
            
            return c;
        }

        public override string ToString()
        {
            int q = gcd(x, y);
            if (x / q == 0)
            {
                return "0";
            }
            else if (x / q == y / q)
            {
                return "1";
            }
            else if (y / q == 0)
            {
                return "ERROR";
            }
            else
            {
                return x / q + "/" + y / q;
            }
            //return string.Format("Complex\nx: {0}\ny:", x, y);
        }

        static int gcd(int x, int y)
        {
            if (x == 0)
            {
                return y;
            }

            return gcd(y % x, x);

        }

        



    }
}
