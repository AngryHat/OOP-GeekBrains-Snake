using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace Snake
{
    class Program
    {
        static void Main(string[] args)
        {
            Walls walls = new Walls(30, 20);
            walls.Draw();

            Point startPoint = new Point(4, 4, '*');
            Snake snake = new Snake(startPoint, 5, Direction.RIGHT);
            snake.Draw();

            FoodCreator foodCreator = new FoodCreator(30, 20, 'g');
            Point food = foodCreator.CreateFood();
            food.Draw();

            while (true)
            {
                Console.CursorVisible = false;

                if (walls.IsHit(snake) || snake.IsHitTail())
                {
                    break;
                }
                if (snake.Eat(food))
                {
                    food = foodCreator.CreateFood();
                    food.Draw();
                }
                else
                {
                    snake.Move();
                }
                Thread.Sleep(200);

                if (Console.KeyAvailable)
                {
                    ConsoleKeyInfo inputKey = Console.ReadKey();
                    snake.Control(inputKey);
                }
            }

            Console.SetCursorPosition(3, 10);
            Console.WriteLine("Game over. Press enter.");
            //end of porgram
            Console.ReadLine();
        }


    }
}
