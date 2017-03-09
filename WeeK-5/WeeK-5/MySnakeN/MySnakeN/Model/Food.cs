﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MySnakeN.Model
{
    

    class Food
    {
        public Point location;
        public ConsoleColor color = ConsoleColor.Green;
        public char sign = '$';

        public Food()
        {
            SetRandomPosition();
            
        }

        public void SetRandomPosition()
        {
            int x = new Random().Next(1, 69);
            int y = new Random().Next(1, 34);

            

            location = new Point(x, y);
        }

        public void Draw()
        {

            Console.ForegroundColor = color;
            Console.SetCursorPosition(location.x, location.y);
            Console.Write(sign);
        }
    }
}
