using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace Snake_OOP
{
    class Program
    {
        static void Main(string[] args)
        {
            
            Console.CursorVisible = false;

            //border
            Walls walls = new Walls(80,25);
            walls.Draw();

            //Snake


            Point p = new Point(5,5, '*');
            Snake snake = new Snake(p,4,Direction.Right);
            snake.Draw();

            Food simpleFood = new Food(80,25,'#');
            Point food1 = simpleFood.CreateFood();
            food1.Draw();




            //gra
            while (true)
            {
                if (walls.IsHit(snake) || snake.IsHitTail())
                {
                    break;
                }


                if (snake.Eat(food1))
                {
                    food1 = simpleFood.CreateFood();
                    food1.Draw();

                }
                else
                {
                    snake.Move();
                }
                Thread.Sleep(100);

                if (Console.KeyAvailable)
                {
                    ConsoleKeyInfo key = Console.ReadKey();
                    snake.ControlMove(key.Key);
                }

                
                
            }
            
            Console.ReadLine();
        }
    }
}
