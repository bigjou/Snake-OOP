using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Snake_OOP
{
    class Point
    {

        int x;
        int y;
        public char sym;

        public Point()
        {
            Console.WriteLine("Punkt został stworzony.");
        }

        public Point(Point p)
        {
            x = p.x;
            y = p.y;
            sym = p.sym;
        }

        public Point(int _x, int _y, char _sym)
        {
            x=_x;
            y=_y;
            sym=_sym;
        }

        public void Draw()
        {
            Console.SetCursorPosition(x,y);
            Console.Write(sym);
        }

        public void Clear()
        {
            sym = ' ';
            Draw();
        }

        public void Move(int offset, Direction _dir)
        {
            //if (_dir == Direction.Right)
            //{
            //    x += offset;
            //}
            //else if (_dir == Direction.Left)
            //{
            //    x -= offset;
            //}
            //else if (_dir == Direction.Up)
            //{
            //    y -= offset;
            //}
            //else if (_dir == Direction.Down)
            //{
            //    y += offset;
            //}

            switch (_dir)
            {
                case Direction.Right:
                    x += offset;
                    break;
                case Direction.Left:
                    x -= offset;
                    break;
                case Direction.Up:
                    y -= offset;
                    break;
                case Direction.Down:
                    y += offset;
                    break;
                default:
                    Console.WriteLine("Problem ze switchem!");
                        break;
            }

        }


        internal bool isHit(Point food1)
        {
            return food1.x == this.x && food1.y == this.y;
        }
    }
}
