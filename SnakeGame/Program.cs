using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace SnakeGame
{
    class Program : Frame
    {
        static void Main(String[] args)
        {
            Frame frame = new Frame()
            {
                width = 100,
                height = 25
            };
            Snake snake = new Snake()
            {
                lenght = 3,
                headX = frame.width / 2,
                headY = frame.height / 2,

            };

            frame.PrintFrame(frame.width, frame.height, snake.headX, snake.headY);
            Thread.Sleep(300);

            while (true)
            {
                snake.MoveUp(snake);
                string input = Console.Read() + "";
                Thread.Sleep(300);
            }

            Console.Read();
           
        }
    }



    class Frame
    {

        public int width { get; set; }
        public int height { get; set; }

        public void PrintFrame(int frameWidth, int frameHeight, int x, int y)
        {
            string frame = "";

            for (int i = 0; i <= frameHeight; i++)
            {

                if (i == 0 || i == frameHeight)
                {
                    for (int j = 0; j <= frameWidth; j++)
                    {
                        frame += "*";
                    }
                }
                else
                {
                    for (int k = 0; k <= frameWidth; k++)
                    {
                        if (k == 0 || k == frameWidth)
                        {
                            frame += "*";
                        }
                        else
                        {
                            if (k == x && i == y)
                            {
                                frame += "*";
                            }
                            else
                            {
                                frame += " ";
                            }
                        }
                    }
                }
                frame += "\n";
            }
            Console.WriteLine(frame);
        }

    }

    class Snake
    {
        public int lenght { get; set; }
        public int headX { get; set; }
        public int headY { get; set; }
        public int bottomX { get; set; }
        public int bottomY { get; set; }


        public void MoveUp(Snake snake)
        {
            snake.headY--;
            Console.SetCursorPosition(snake.headX, snake.headY);

            Console.Write("*");
        }

        public void MoveDown(Snake snake)
        {
            Console.SetCursorPosition(snake.headX, snake.headY);
            Console.Write("*");
        }

        public void MoveRight(Snake snake)
        {
            Console.SetCursorPosition(snake.headX, snake.headY);
            Console.Write("*");
        }

        public void MoveLeft(Snake snake)
        {
            Console.SetCursorPosition(snake.headX, snake.headY);
            Console.Write("*");
        }



    }

}
