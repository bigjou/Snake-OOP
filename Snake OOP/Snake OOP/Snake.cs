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

        public void ControlMove(ConsoleKey _key)
        {
            switch (_key)
            {
                case ConsoleKey.LeftArrow :
                    dir = Direction.Left;
                    break;
                case ConsoleKey.RightArrow:
                    dir = Direction.Right;
                    break;
                case ConsoleKey.UpArrow:
                    dir = Direction.Up;
                    break;
                case ConsoleKey.DownArrow:
                    dir = Direction.Down;
                    break;
                default :
                    dir = Direction.Right;
                        break;
            }
        }

        internal bool Eat(Point food1)
        {

            Point head = GetNextPointOfSnake();
            if (head.isHit(food1))
            {
                food1.sym = head.sym;
                plist.Add(food1);
                //food1.Draw();
                return true;
            }
            else
                return false;
        }

        internal bool IsHitTail()
        {
            var head = plist.Last();
            for (int i = 0; i < plist.Count -2;i++ )
            {
                if (head.isHit(plist[i]))
                    return true;
            }
            return false;
        }
    }
}
