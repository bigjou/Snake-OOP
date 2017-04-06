using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Snake_OOP
{
    class VerticalLine
    {
        List<Point> plist;

        public VerticalLine(int x, int yTop, int yDown, char sym)
        {
            plist = new List<Point>();

            for (int y = yTop; y <= yDown; y++)
            {
                Point p = new Point(x, y, sym);
                plist.Add(p);
            }

        }

        public void Draw()
        {
            foreach (Point p in plist)
            {
                p.Draw();
            }
        }

    }
}
