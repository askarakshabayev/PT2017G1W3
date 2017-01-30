using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Example3.Models
{
    class Snake
    {
        public List<Point> body;
        public char sign;
        public ConsoleColor color;

        public Snake()
        {
            body = new List<Point>();
            body.Add(new Point(10, 10));
            sign = '*';
            color = ConsoleColor.Yellow;
        }

        public void move(int dx, int dy)
        {
            for (int i = 1; i < body.Count; i++)
            {
                body[i].x = body[i - 1].x;
                body[i].y = body[i - 1].y;
            }
            body[0].x += dx;
            body[0].y += dy;
        }

        public void addItem() {
            Point p = new Point(0, 0);
            body.Add(p);
        }
    }
}
