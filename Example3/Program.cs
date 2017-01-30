using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace Example3
{
    class Program
    {
        static void Main(string[] args)
        {
            Models.Snake snake = new Models.Snake();
            int cnt = 0;
            while (true)
            {
                cnt++;

                ConsoleKeyInfo pressedKey = Console.ReadKey();
                if (pressedKey.Key == ConsoleKey.UpArrow)
                    snake.move(0, -1);
                if (pressedKey.Key == ConsoleKey.DownArrow)
                    snake.move(0, 1);
                if (pressedKey.Key == ConsoleKey.LeftArrow)
                    snake.move(-1, 0);
                if (pressedKey.Key == ConsoleKey.RightArrow)
                    snake.move(1, 0);
                //Console.Clear();
                for (int i = 0; i < snake.body.Count; i++)
                {
                    Console.SetCursorPosition(snake.body[i].x, snake.body[i].y);
                    Console.Write(snake.sign);
                    Console.Write(snake.body.Count);
                }
                if (cnt % 10 == 0)
                    snake.addItem();
            }
        }
    }
}
