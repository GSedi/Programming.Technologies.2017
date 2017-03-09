using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MySnakeN.Model;

namespace MySnakeN
{
    class Program
    {
        static Snake snake = new Snake();
        static Food food = new Food();
        static Wall wall = new Wall(1);
        

        static bool GameOver = false;



        static void Main(string[] args)
        {
            Console.CursorVisible = false;

            Console.SetWindowSize(70, 35);

            while (!GameOver)
            {

                Console.Clear();

                snake.Draw();
                food.Draw();
                wall.Draw();

                ConsoleKeyInfo btn = Console.ReadKey();

                switch (btn.Key)
                {
                    case ConsoleKey.UpArrow:

                        snake.Move(0, -1);
                        break;

                    case ConsoleKey.DownArrow:
                        snake.Move(0, 1);
                        break;

                    case ConsoleKey.LeftArrow:
                        snake.Move(-1, 0);
                        break;

                    case ConsoleKey.RightArrow:
                        snake.Move(1, 0);
                        break;

                    case ConsoleKey.Escape:
                        GameOver = true;
                        break;

                }

                if (snake.CanEat(food))
                {

                    food.SetRandomPosition();

                }

                if (snake.body.Count == 4)
                {
                    wall = new Model.Wall(2);
                } else if (snake.body.Count == 7)
                {
                    wall = new Model.Wall(3);
                }
                       
                
                
                  
                
                for (int i = 0; i < wall.body.Count; i++)
                {

                    if (snake.body[0].x == wall.body[i].x && snake.body[0].y == wall.body[i].y)
                    {
                        Console.Clear();
                        Console.WriteLine("Game Over");
                        Console.ReadKey();
                        GameOver = true;
                    }
                }
               

                for (int i = 2; i < snake.body.Count; i++)
                {

                    if (snake.body[0].x == snake.body[i].x && snake.body[0].y == snake.body[i].y)
                    {
                        Console.Clear();
                        Console.WriteLine("Game Over");
                        Console.ReadKey();
                        GameOver = true;

                    }
                }


            }
        }
    }
}
