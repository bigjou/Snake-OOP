using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Snake_OOP
{
    class Snake : Figure
    {

        public Snake(Point tail, int length, Direction dir)
        {
            plist = new List<Point>();
            for (int i = 0; i < length; i++ )
            {
                Point p = new Point(tail);
                p.Move(i, dir);
                plist.Add(p);
            }
        }

    }
}
