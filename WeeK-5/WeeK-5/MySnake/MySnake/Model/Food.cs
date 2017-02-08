using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MySnake.Model
{
    class Food
    {
        public char ss;
        public List<Point> foo;

        public Food()
        {
            foo = new List<Point>();
            ss = '$';
            foo.Add(new Point(20, 20));
        }

        public void generate()
        {
            Console.Clear();

            foreach(Point pp in foo)
            {
                Console.SetCursorPosition(pp.x, pp.y);
                Console.Write(ss);
            }
        }


    }
}
