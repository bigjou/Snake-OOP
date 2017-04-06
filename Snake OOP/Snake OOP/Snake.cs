using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Snake_OOP
{
    class Snake : Figure
    {

        Direction dir;

        public Snake(Point tail, int length, Direction _dir)
        {
            dir = _dir;
            plist = new List<Point>();
            for (int i = 0; i < length; i++ )
            {
                Point p = new Point(tail);
                p.Move(i, _dir);
                plist.Add(p);
            }
        }


        internal void Move()
        {
            //operacje na liscie
            Point tail = plist.First();
            plist.Remove(tail);
            Point head = GetNextPointOfSnake();
            plist.Add(head);

            //rysowanie
            tail.Clear();
            head.Draw();
        }

        public Point GetNextPointOfSnake()
        {
            Point head = plist.Last();
            Point nextPont = new Point(head);
            nextPont.Move(1, dir);
            return nextPont;
        }
    }
}
